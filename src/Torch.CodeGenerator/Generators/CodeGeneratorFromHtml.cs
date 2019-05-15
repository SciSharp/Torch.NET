using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
                    SetReturnType(decl, node);

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

            // { new Argument() { type = GenerateReturnType(decl) } };
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
