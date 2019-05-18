using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using CodeMinion.Core;
using CodeMinion.Core.Models;
using HtmlAgilityPack;

namespace Torch.ApiGenerator
{
    public class NumpyApiGenerator
    {
        private CodeGenerator _generator;
        public NumpyApiGenerator()
        {
            _generator = new CodeGenerator
            {
                NameSpace = "Numpy",
                Usings = { "using NumSharp;" },
            };
        }

        public string Generate()
        {
            var docs = LoadDocs();
            var api = new StaticApi()
            {
                StaticName = "np", // name of the static API class
                ImplName = "NumPy", // name of the singleton that implements the static API behind the scenes
                PythonModule = "numpy" // name of the Python module that the static api wraps 
            };
            _generator.StaticApis.Add(api);
            foreach (var html_doc in docs)
            {
                var doc = html_doc.Doc;
                // declaration
                var h1 = doc.DocumentNode.Descendants("h1").FirstOrDefault();
                if (h1==null)
                    continue;
                var dl = doc.DocumentNode.Descendants("dl").FirstOrDefault();
                if (dl==null || dl.Attributes["class"]?.Value!="function") continue;
                var class_name = doc.DocumentNode.Descendants("code")
                    .First(x => x.Attributes["class"]?.Value == "descclassname").InnerText;
                var func_name = doc.DocumentNode.Descendants("code")
                    .First(x => x.Attributes["class"]?.Value == "descname").InnerText;
                var decl = new Declaration() { Name = func_name, ClassName= class_name.TrimEnd('.') };
                var table = doc.DocumentNode.Descendants("table")
                    .FirstOrDefault(x => x.Attributes["class"]?.Value == "docutils field-list");
                if (table==null)
                    continue;
                // arguments
                ParseArguments(html_doc, table, decl);

                // return type(s)
                ParseReturnTypes(html_doc, table, decl);

                // if necessary create overloads
                foreach (var d in InferOverloads(decl))
                    api.Declarations.Add(d);
            }
            var dir = Directory.GetCurrentDirectory();
            var src_dir = dir.Substring(0, dir.LastIndexOf("\\src\\")) + "\\src\\";
            api.OutputPath = Path.Combine(src_dir, "Torch");
            _generator.Generate();
            return "DONE";
        }

        private void ParseArguments(HtmlDoc html_doc, HtmlNode table, Declaration decl)
        {
            var tr = table.Descendants("tr").FirstOrDefault();
            if (tr == null)
                return;
            foreach (var dt in tr.Descendants("dt"))
            {
                var arg = new Argument();
                var strong = dt.Descendants("strong").FirstOrDefault();
                if (strong==null)
                    continue;
                arg.Name =strong.InnerText;
                var type_description = dt.Descendants("span")
                    .First(span => span.Attributes["class"]?.Value == "classifier").InnerText;
                var type = type_description.Split(",").FirstOrDefault();
                arg.Type = InferType(arg.Name, type);
                if (type_description.Contains("optional"))
                {
                    arg.IsNamedArg = true;
                    arg.IsNullable = true;
                }
                if (type_description.Contains("default:"))
                    arg.DefaultValue = InferDefaultValue(type_description.Split(",")
                        .First(x => x.Contains("default: ")).Replace("default: ", ""));
                PostProcess(arg);
                decl.Arguments.Add(arg);
            }
        }

        private void PostProcess(Argument arg)
        {
            if (arg.Name == "order")
                arg.DefaultValue = null;
        }

        private void ParseReturnTypes(HtmlDoc html_doc, HtmlNode table, Declaration decl)
        {
            var tr = table.Descendants("tr").FirstOrDefault(x => x.InnerText.StartsWith("Returns:"));
            if (tr == null)
                return;
            foreach (var dt in tr.Descendants("dt"))
            {
                var arg = new Argument();
                //arg.Name = dt.Descendants("strong").First().InnerText;
                var type_description = dt.Descendants("span")
                    .First(span => span.Attributes["class"]?.Value == "classifier").InnerText;
                var type = type_description.Split(",").FirstOrDefault();
                arg.Type = InferType(arg.Name, type);
                decl.Returns.Add(arg);
            }
        }

        private IEnumerable<Declaration> InferOverloads(Declaration decl)
        {
            // todo
            yield return decl;
        }

        private string InferDefaultValue(string default_value)
        {
            // string
            //if (Regex.IsMatch(default_value, @"$‘(.+)’"))
            //    return $"\"{ default_value.Trim('\'', '‘', '’') }\""; //   ‘C’ => "C"
            return default_value;
        }

        private string InferType(string argname, string type)
        {
            switch (argname)
            {
                case "shape": return "NumSharp.Shape";
                case "dtype": return "Dtype";
                case "order": return "string";
            }               
            switch (type)
            {
                case "data-type": return "Dtype";
                case "ndarray": return "NDarray";
            }
            if (type.StartsWith("ndarray"))
                return "NDarray";
            return type;
        }

        string BaseUrl = "https://docs.scipy.org/doc/numpy-1.16.1/reference/";

        public List<HtmlDoc> LoadDocs()
        {
            var docs = new List<HtmlDoc>();
            var doc = GetHtml("routines.array-creation.html");
            LoadDocsFromOverviewPage(doc.Doc, docs);
            return docs;
        }

        private void LoadDocsFromOverviewPage(HtmlDocument doc, List<HtmlDoc> docs)
        {
            var nodes = doc.DocumentNode.Descendants("a")
                .Where(x => x.Attributes["class"]?.Value == "reference internal")
                .ToList();
            foreach (var node in nodes)
            {
                var relative_link = node.Attributes["href"].Value;
                if (!relative_link.StartsWith("generated"))
                    continue;
                var uri = relative_link.Split("#").First();
                docs.Add(GetHtml(uri));
            }
        }

        HtmlDoc GetHtml(string relative_url)
        {
            Console.WriteLine("Loading: " + relative_url);
            var doc = new HtmlDoc();
            doc.Filename = relative_url.Replace("/", "_");
            if (File.Exists(doc.Filename))
            {
                doc.Doc = new HtmlDocument();
                doc.Doc.Load(doc.Filename);
                doc.Text = doc.Doc.Text;
                return doc;
            }
            var web = new HtmlWeb();
            doc.Doc = web.Load(BaseUrl + relative_url);
            doc.Text = doc.Doc.Text;
            File.WriteAllText(doc.Filename, doc.Text);
            return doc;
        }
    }
}

