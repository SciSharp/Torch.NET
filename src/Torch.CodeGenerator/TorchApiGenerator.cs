using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using CodeMinion.Core;
using CodeMinion.Core.Models;

namespace Torch.CodeGenerator
{
    public class TorchApiGenerator : CodeGeneratorBase, ICodeGenerator
    {

        public TorchApiGenerator()
        {
            NameSpace = "Torch";
            Usings.Add("using NumSharp;");
        }
        private StaticApi torch_api = new StaticApi() {StaticName = "torch", SingletonName = "PyTorch", PythonModule = "torch" };

        // generate these API calls
        protected bool InMigrationApiList(string apiName)
        {
            var apis = new string[] { "empty", "tensor" };

            return apis.Contains(apiName);
        }

        private HashSet<string> ManualOverride = new HashSet<string>() { "tensor" };


        public string Generate()
        {
            LoadTemplates();
            var docs = LoadDocs();

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
                    if (ManualOverride.Contains(decl.Name)) continue;
                    if (!InMigrationApiList(decl.Name)) continue;
                    SetReturnType(decl, node);
                    SetParameters(decl, node);

                    torch_api.Declarations.Add(decl);
                }
            }

            var dir = Directory.GetCurrentDirectory();
            var src_dir = dir.Substring(0, dir.LastIndexOf("\\src\\")) + "\\src\\";
            var out_path = Path.Combine(src_dir, "Torch\\torch.gen.cs");
            WriteFile(out_path, s =>
            {
                GenerateStaticApi(torch_api, s);
            });
            out_path = Path.Combine(src_dir, "Torch\\PyTorch.gen.cs");
            WriteFile(out_path, s =>
            {
                GenerateApiImplementation(torch_api, s);
            });
            return "DONE";
        }

        protected void WriteFile(string path, Action<StringBuilder> generate_action)
        {
            var s = new StringBuilder();
            try
            {
                generate_action(s);
            }
            catch (Exception e)
            {
                s.AppendLine("\r\n --------------- generator exception ---------------------");
                s.AppendLine(e.Message);
                s.AppendLine(e.StackTrace);
            }
            File.WriteAllText(path, s.ToString());
        }

        private void SetFunctionName(Declaration decl, HtmlNode node)
        {
            decl.Name = node.Element("dt").Descendants().First(x => x.Attributes["class"]?.Value == "descname").InnerText.Replace(".", string.Empty);
        }

        private void SetReturnType(Declaration decl, HtmlNode node)
        {
            decl.returns = new List<Argument>();
            if (decl.Name.StartsWith("is_"))
            {
                decl.returns.Add(new Argument { Type = "bool" });
            }

            if(node.Element("dt").InnerText.Contains("&#x2192; Tensor"))
            {
                decl.returns.Add(new Argument { Type = "Tensor" });
            }
        }

        private void SetParameters(Declaration decl, HtmlNode node)
        {
            decl.Arguments = new List<Argument>();
            var p_nodes = node.Descendants("dd").First().Descendants("dl").FirstOrDefault();
            if (p_nodes == null) return;

            var p_node = p_nodes.Descendants("dd").First();
            if (p_node.InnerHtml == "")
            {
                Console.WriteLine($"Skipped {decl.Name}");
                return;
            }

            if (p_node.Element("ul") != null) // multiple parameters
            {
                foreach(var li in p_node.Element("ul").Elements("li"))
                {
                    var arg = new Argument();

                    // precision – Number of digits of precision for floating point output(default = 4).
                    var p_desc = li.InnerText;
                    arg.Name = p_desc.Split(' ')[0];

                    var type_part = Regex.Match(p_desc, @"\(\S+, optional\)")?.Value; //(torch.dtype, optional)
                    if (!string.IsNullOrEmpty(type_part))
                    {
                        arg.Type = type_part.Split(',')[0].Substring(1).Trim();
                        arg.IsNullable = true;
                        arg.IsNamedArg = true;
                    }

                    type_part = Regex.Match(p_desc, @"\(int...\)")?.Value; //(int...)
                    if (!string.IsNullOrEmpty(type_part))
                        arg.Type = "int...";

                    var default_part = Regex.Match(p_desc, @"\(default = \d+\)")?.Value; //(default = 4)
                    if (!string.IsNullOrEmpty(default_part))
                    {
                        arg.DefaultValue = default_part.Split('=')[1].Replace(")", string.Empty);
                        // infer data type
                        if (string.IsNullOrEmpty(arg.Type))
                            arg.Type = InferDataType(arg.DefaultValue, p_desc.Split('–')[1]);
                        arg.IsNamedArg = true;
                    }

                    if (string.IsNullOrEmpty(arg.Type))
                    {
                        arg.Type = InferDataType(Regex.Match(p_desc, @"\(\S+\)")?.Value, p_desc.Split('–')[1]);
                    }

                    decl.Arguments.Add(arg);
                }
            }
            else
            {
                var arg = new Argument();

                var p_desc = p_node.InnerText; // obj (Object) – Object to test
                arg.Name = p_desc.Split(' ')[0];
                // may contain type desc
                var type_part = Regex.Match(p_desc.Split('–')[0], @"\([\S,\s]+\):")?.Value; // (list of Tensor):
                if (!string.IsNullOrEmpty(type_part))
                    arg.Type = InferDataType(type_part.Replace(":", string.Empty), p_desc);
                if (string.IsNullOrEmpty(arg.Type))
                    arg.Type = p_desc.Split('–')[0].Split(' ')[1].Replace("(", string.Empty).Replace(")", string.Empty);
                //var desc = p_desc.Split('–')[1].Trim();

                decl.Arguments.Add(arg);
            }
        }

        protected string InferDataType(string value, string hint)
        {
            switch (value)
            {
                case "(array_like)":
                    return "(array_like)"; // keep it like that so we can generate overloads
                case "(int)":
                    return "int";
                case "(list of Tensor)":
                    return "Tensor[]";
            }

            if (hint.ToLower().Contains("number of "))
                return "int";

            return "string";
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
