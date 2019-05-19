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
                //PrintModelJson=true,  // <-- if enabled prints the declaration model as JSON for debugging reasons
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
                // function description
                var dd = dl.Descendants("dd").FirstOrDefault();
                decl.Description=ParseDescription(dd);
                var table = doc.DocumentNode.Descendants("table")
                    .FirstOrDefault(x => x.Attributes["class"]?.Value == "docutils field-list");
                if (table==null)
                    continue;
                // arguments
                ParseArguments(html_doc, table, decl);

                // return type(s)
                ParseReturnTypes(html_doc, table, decl);

                PostProcess(decl);
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

        private string ParseDescription(HtmlNode dd)
        {
            if (dd == null)
                return null;
            var desc = string.Join("\r\n\r\n", dd.ChildNodes.Where(n => n.Name == "p").Select(p => p.InnerText).TakeWhile(s=>!s.StartsWith("Examples")));
            return desc;
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
                arg.Type = InferType(type, arg);
                if (type_description.Contains("optional"))
                {
                    arg.IsNamedArg = true;
                    arg.IsNullable = true;
                }
                if (type_description.Contains("default:"))
                    arg.DefaultValue = InferDefaultValue(type_description.Split(",")
                        .First(x => x.Contains("default: ")).Replace("default: ", ""));
                var dd = dt.NextSibling?.NextSibling;
                arg.Description = ParseDescription(dd);
                PostProcess(arg);
                decl.Arguments.Add(arg);
            }
        }

        private void PostProcess(Argument arg)
        {
            if (arg.Name == "order")
                arg.DefaultValue = null;
            switch (arg.Type)
            {
                //case "int[]":
                //case "Hashtable":
                //    arg.IsValueType = false;
                //    break;
                case "Dtype":
                    arg.IsValueType = true;
                    break;
            }
        }

        private void PostProcess(Declaration decl)
        {
            if (decl.Arguments.Any(a => a.Type == "buffer_like"))
                decl.CommentOut = true;
            // iterable object            
            if (decl.Arguments.Any(a => a.Type == "IEnumerable<T>"))
            {
                        decl.Generics = new string[] { "T" };
                        if (decl.Returns[0].Type == "NDarray") // TODO: this feels like a hack. make it more robust if necessary
                            decl.Returns[0].Type = "NDarray<T>";
            }

            switch (decl.Name)
            {
                case "arange":
                    decl.Arguments[0].IsNullable = false;
                    decl.Arguments[0].DefaultValue = "0";
                    decl.Arguments[2].DefaultValue = "1";
                    decl.Arguments[2].IsNullable = false;
                    decl.Arguments[3].IsNullable = false;
                    decl.Arguments[3].IsNamedArg = true;
                    break;
                case "logspace":
                case "geomspace":
                    decl.Arguments.First(a => a.Type == "Dtype").IsNullable = true;
                    decl.Arguments.First(a => a.Type == "Dtype").IsNamedArg = true;
                    break;
                case "meshgrid":
                case "mat":
                case "bmat":
                    decl.CommentOut = true;
                    break;
            }
        }
        
        private void ParseReturnTypes(HtmlDoc html_doc, HtmlNode table, Declaration decl)
        {
            var tr = table.Descendants("tr").FirstOrDefault(x => x.InnerText.StartsWith("Returns:"));
            if (tr == null)
                return;
            foreach (var dt in tr.Descendants("dt"))
            {
                var arg = new Argument();
                var strong = dt.Descendants("strong").FirstOrDefault();
                if(strong!=null)
                    arg.Name = strong.InnerText;
                var type_description = dt.Descendants("span")
                    .First(span => span.Attributes["class"]?.Value == "classifier").InnerText;
                var type = type_description.Split(",").FirstOrDefault();
                arg.Type = InferType(type, arg);
                var dd = dt.NextSibling?.NextSibling;
                arg.Description = ParseDescription(dd);
                decl.Returns.Add(arg);
            }
        }

        private IEnumerable<Declaration> InferOverloads(Declaration decl)
        {
            // without args we don't need to consider possible overloads
            if (decl.Arguments.Count == 0)
            {
                yield return decl;
                yield break;
            }
            if (decl.Name == "arange")
            {
                foreach (var d in ExpandArange(decl))
                    yield return d;
                yield break;
            }
            // array_like
            if (decl.Arguments.Any(a=>a.Type == "array_like"))
            {
                foreach (var type in "NDarray T[]".Split())
                {
                    var clone_decl = decl.Clone();
                    clone_decl.Arguments.ForEach(a =>
                    {
                        if (a.Type == "array_like")
                            a.Type = type;
                    });
                    if (type == "T[]")
                    {
                        clone_decl.Generics = new string[] {"T"};
                        if (clone_decl.Returns[0].Type == "NDarray") // TODO: this feels like a hack. make it more robust if necessary
                            clone_decl.Returns[0].Type = "NDarray<T>";
                    }
                    yield return clone_decl;
                }
                yield break;
            }
            // number
            if (decl.Arguments.Any(a => a.Type == "number"))
            {
                foreach (var type in "byte short int long float double".Split())
                {
                    var clone_decl = decl.Clone();
                    clone_decl.Arguments.ForEach(a =>
                    {
                        if (a.Type == "number")
                            a.Type = type;
                    });
                    yield return clone_decl;
                }
                yield break;
            }
            if (decl.Name == "bmat")
            {
                decl.Arguments[0].Type = "string";
                yield return decl;
                var clone_decl = decl.Clone();
                clone_decl.Arguments[0].Type = "T[]";
                clone_decl.Generics = new []{"T"};
                clone_decl.Returns[0].Type = "matrix<T>";
                yield return clone_decl;
                yield break;

            }
            yield return decl;
        }

        // special treatment for np.arange which is a "monster"
        private IEnumerable<Declaration> ExpandArange(Declaration decl)
        {
            // numpy.arange([start, ]stop, [step, ]dtype=None)
            var dtype = decl.Arguments.Last();
            dtype.IsNullable = true;
            dtype.IsNamedArg = true;
            if (decl.Arguments.Any(a => a.Type == "number"))
            {
                foreach (var type in "byte short int long float double".Split())
                {
                    // start, stop
                    var clone_decl = decl.Clone();
                    clone_decl.Arguments.ForEach(a =>
                    {
                        if (a.Type == "number")
                            a.Type = type;
                    });
                    clone_decl.Arguments[0].IsNamedArg = false;
                    clone_decl.Arguments[0].IsNullable = false;
                    clone_decl.Arguments[0].DefaultValue=null;
                    yield return clone_decl;
                    // [start=0] <-- remove start from arg list
                    clone_decl = clone_decl.Clone(); // <---- clone from the clone, as it has the correct type
                    clone_decl.Arguments.RemoveAt(0);
                    yield return clone_decl;
                }
                yield break;
            }
        }

        private string InferDefaultValue(string default_value)
        {
            // string
            //if (Regex.IsMatch(default_value, @"$‘(.+)’"))
            //    return $"\"{ default_value.Trim('\'', '‘', '’') }\""; //   ‘C’ => "C"
            return default_value;
        }

        private string InferType(string type, Argument arg)
        {
            switch (arg.Name)
            {
                case "shape": return "NumSharp.Shape";
                case "dtype": return "Dtype";
                case "order": return "string";
            }               
            switch (type)
            {
                case "data-type": return "Dtype";
                case "ndarray": return "NDarray";
                case "scalar": return "ValueType";
                case "file": return "string";
                case "str": return "string";
                case "file or str": return "string";
                case "str or sequence of str": return "string[]";
                case "array of str or unicode-like": return "string[]";
                case "callable": return "Delegate";
                case "any": return "object";
                case "iterable object": return "IEnumerable<T>";
                case "dict": return "Hashtable";
                case "int or sequence": return "int[]";
                case "boolean": return "bool";
                case "integer": return "int";
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

