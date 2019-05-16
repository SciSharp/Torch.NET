using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Torch.CodeGenerator.Models;

namespace Torch.CodeGenerator
{
    public class CodeGeneratorFromHtml : CodeGeneratorBase, ICodeGenerator
    {
        public string Generate()
        {
            var docs = LoadDocs();
            var s = new StringBuilder();

            foreach(var html in docs)
            {
                var doc = new HtmlDocument();
                doc.LoadHtml(html.Value);

                /*<dt id="torch.is_tensor">
                    <code class="descclassname">torch.</code><code class="descname">is_tensor</code><span class="sig-paren">(</span><em>obj</em><span class="sig-paren">)</span><a class="reference internal" href="_modules/torch.html#is_tensor"><span class="viewcode-link">[source]</span></a><a class="headerlink" href="#torch.is_tensor" title="Permalink to this definition">¶</a></dt>
                        <dd><p>Returns True if <cite>obj</cite> is a PyTorch tensor.</p>
                        <dl class="field-list simple">
                        <dt class="field-odd">Parameters</dt>
                        <dd class="field-odd"><p><strong>obj</strong> (<em>Object</em>) – Object to test</p>
                        </dd>
                    </dl>
                </dd>*/
                var nodes = doc.DocumentNode.Descendants("dl")
                     .Where(x => x.Attributes["class"]?.Value == "function")
                     .ToList();

                foreach (var node in nodes)
                {
                    var decl = new Declaration();
                    SetFunctionName(decl, node);
                    if (!InMigrationApiList(decl.name)) continue;
                    SetReturnType(decl, node);
                    SetParameters(decl, node);

                    Console.WriteLine(decl.schema_string);
                    GenerateApiFunction(decl, s);
                }
            }

            return s.ToString();
        }

        private void SetFunctionName(Declaration decl, HtmlNode node)
        {
            decl.name = node.Element("dt").Descendants().First(x => x.Attributes["class"]?.Value == "descname").InnerText.Replace(".", string.Empty);
        }

        private void SetReturnType(Declaration decl, HtmlNode node)
        {
            decl.returns = new List<Argument>();
            if (decl.name.StartsWith("is_"))
            {
                decl.returns.Add(new Argument
                {
                    type = "bool"
                });
            }

            if(node.Element("dt").InnerText.Contains("&#x2192; Tensor"))
            {
                decl.returns.Add(new Argument
                {
                    type = "Tensor"
                });
            }
        }

        private void SetParameters(Declaration decl, HtmlNode node)
        {
            decl.arguments = new List<Argument>();
            var p_nodes = node.Descendants("dd").First().Descendants("dl").FirstOrDefault();
            if (p_nodes == null) return;

            var p_node = p_nodes.Descendants("dd").First();
            if (p_node.InnerHtml == "")
            {
                Console.WriteLine($"Skipped {decl.name}");
                return;
            }

            if (p_node.Element("ul") != null) // multiple parameters
            {
                foreach(var li in p_node.Element("ul").Elements("li"))
                {
                    var arg = new Argument();

                    // precision – Number of digits of precision for floating point output(default = 4).
                    var p_desc = li.InnerText;
                    arg.name = p_desc.Split(' ')[0];

                    var type_part = Regex.Match(p_desc, @"\(\S+, optional\)")?.Value; //(torch.dtype, optional)
                    if (!string.IsNullOrEmpty(type_part))
                    {
                        arg.type = type_part.Split(',')[0].Substring(1).Trim();
                        arg.is_nullable = true;
                    }

                    type_part = Regex.Match(p_desc, @"\(int...\)")?.Value; //(int...)
                    if (!string.IsNullOrEmpty(type_part))
                        arg.type = "int...";

                    var default_part = Regex.Match(p_desc, @"\(default = \d+\)")?.Value; //(default = 4)
                    if (!string.IsNullOrEmpty(default_part))
                    {
                        arg.@default = default_part.Split('=')[1].Replace(")", string.Empty);
                        // infer data type
                        if (string.IsNullOrEmpty(arg.type))
                            arg.type = InferDataType(arg.@default, p_desc.Split('–')[1]);
                    }

                    if (string.IsNullOrEmpty(arg.type))
                    {
                        arg.type = InferDataType(Regex.Match(p_desc, @"\(\S+\)")?.Value, p_desc.Split('–')[1]);
                    }

                    decl.arguments.Add(arg);
                }
            }
            else
            {
                var arg = new Argument();

                var p_desc = p_node.InnerText; // obj (Object) – Object to test
                arg.name = p_desc.Split(' ')[0];
                // may contain type desc
                var type_part = Regex.Match(p_desc.Split('–')[0], @"\([\S,\s]+\):")?.Value; // (list of Tensor):
                if (!string.IsNullOrEmpty(type_part))
                    arg.type = InferDataType(type_part.Replace(":", string.Empty), p_desc);
                if (string.IsNullOrEmpty(arg.type))
                    arg.type = p_desc.Split('–')[0].Split(' ')[1].Replace("(", string.Empty).Replace(")", string.Empty);
                //var desc = p_desc.Split('–')[1].Trim();

                decl.arguments.Add(arg);
            }
        }


        public Dictionary<string, string> LoadDocs()
        {
            var docs = new Dictionary<string, string>();

            // torch.html
            string url = "https://pytorch.org/docs/stable/torch.html";

            HtmlDocument doc;

            if (File.Exists("torch.html"))
            {
                doc = new HtmlDocument();
                doc.Load("torch.html");
            }
            else
            {
                var web = new HtmlWeb();
                doc = web.Load(url);
                File.WriteAllText("torch.html", doc.Text);
            }

            docs["torch"] = doc.Text;

            return docs;
        }
    }
}
