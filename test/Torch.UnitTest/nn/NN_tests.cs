using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numpy.Models;
using NUnit.Framework;
using Python.Runtime;
using Assert = NUnit.Framework.Assert;

namespace Torch.nn
{
    [TestClass]
    public class NN_tests : BaseTestCase
    {
        [Test]
        public void ParameterTest()
        {
            var Parameter = torch.dynamic_self.GetAttr("nn").GetAttr("Parameter");
            Console.WriteLine(Parameter.ToString());
            var x = torch.tensor(new double[] { 1, 2, 3 });
            var p = Parameter(x.PyObject, requires_grad: false);
            var p1 = (torch.self.GetAttr("nn") as PyObject).InvokeMethod("Parameter", new PyTuple(new PyObject[] { x.PyObject }), Py.kw("requires_grad", new PyObject(Runtime.PyTrue)));
            Console.WriteLine(p.ToString());
            Console.WriteLine(p1.ToString());
            // 
            var p2 = new torch.nn.Parameter(x, true);
            Assert.AreEqual(p1.ToString(), p2.ToString());
        }

        [TestMethod]
        public void ModuleDict()
        {
            var a = new torch.nn.Conv1d(2, 2, 5);
            var b = new torch.nn.Conv1d(1, 1, 3);
            var dict = new torch.nn.ModuleDict(
                ("a", a),
                ("b", b)
            );
            Assert.AreEqual(a.repr, dict["a"].repr);
            Assert.AreNotEqual(a.repr, dict["b"].repr);
            Assert.AreEqual(b.repr, dict["b"].repr);
            Assert.Throws<PythonException>(()=>
            {
                var x=dict["nothing"];
            });
            var items = dict.items().ToArray();
            Assert.AreEqual(2, items.Length);
            Assert.AreEqual("a", items[0].Item1);
            Assert.AreEqual("b", items[1].Item1);
            Assert.AreEqual("Conv1d(2, 2, kernel_size=(5,), stride=(1,))", items[0].Item2.repr);
            Assert.AreEqual("Conv1d(1, 1, kernel_size=(3,), stride=(1,))", items[1].Item2.repr);
            Assert.AreEqual("a, b", string.Join(", ", dict.keys()));
            Assert.AreEqual("Conv1d(2, 2, kernel_size=(5,), stride=(1,))|Conv1d(1, 1, kernel_size=(3,), stride=(1,))", string.Join("|", dict.values().Select(v=>v.repr)));
            Assert.AreEqual("a, b", string.Join(", ", dict.Select(x=>x.Item1)));
            Assert.AreEqual("Conv1d(2, 2, kernel_size=(5,), stride=(1,))|Conv1d(1, 1, kernel_size=(3,), stride=(1,))", string.Join("|", dict.Select(x => x.Item2.repr)));
            Assert.AreEqual("Conv1d(2, 2, kernel_size=(5,), stride=(1,))", dict.pop("a").repr);
            Assert.AreEqual(1,dict.items().Count());
            dict.clear();
            Assert.AreEqual(0, dict.items().Count());
            dict.update(("a", a), ("b", b));
            Assert.AreEqual(2, dict.items().Count());
            var a1 = new torch.nn.Conv1d(dict["a"]);
            Assert.AreEqual(a.repr, a1.repr);
            Assert.AreEqual(2, dict.len());
        }

        [TestMethod]
        public void ModuleList()
        {
            var a = new torch.nn.Conv1d(2, 2,  5 );
            var b = new torch.nn.Conv1d(1, 1,  3 );
            var list = new torch.nn.ModuleList(a,b);
            Assert.AreEqual(a.repr, list[0].repr);
            Assert.AreNotEqual(a.repr, list[1].repr);
            Assert.AreEqual(b.repr, list[1].repr);
            Assert.Throws<PythonException>(() =>
            {
                var x=list[2];
            });
            Assert.AreEqual(2, list.Count());
            Assert.AreEqual("Conv1d(2, 2, kernel_size=(5,), stride=(1,))", list[0].repr);
            Assert.AreEqual("Conv1d(1, 1, kernel_size=(3,), stride=(1,))", list[1].repr);
            Assert.AreEqual("Conv1d(2, 2, kernel_size=(5,), stride=(1,))|Conv1d(1, 1, kernel_size=(3,), stride=(1,))", string.Join("|", list.Select(v => v.repr)));
            list.extend(b);
            Assert.AreEqual(3, list.Count());
            list.append(a);
            Assert.AreEqual(4, list.Count());
            list.insert(2, a);
            Assert.AreEqual(new[]{a,b,a,b,a}.Select(x=>x.repr).ToArray(), list.Select(x=>x.repr).ToArray());
            Assert.AreEqual(5, list.len());
        }


        [TestMethod]
        public void ParameterDict()
        {
            var a = new torch.nn.Parameter(new[] { 0.5 });
            var b = new torch.nn.Parameter(new[] { 0.3 });
            var dict = new torch.nn.ParameterDict(
                ("a", a),
                ("b", b)
            );
            Assert.AreEqual(a.repr, dict["a"].repr);
            Assert.AreNotEqual(a.repr, dict["b"].repr);
            Assert.AreEqual(b.repr, dict["b"].repr);
            Assert.Throws<PythonException>(() =>
            {
                var x = dict["nothing"];
            });
            var items = dict.items().ToArray();
            Assert.AreEqual(2, items.Length);
            Assert.AreEqual("a", items[0].Item1);
            Assert.AreEqual("b", items[1].Item1);
            Assert.AreEqual("Parameter containing:\ntensor([0.5000], dtype=torch.float64, requires_grad=True)", items[0].Item2.repr);
            Assert.AreEqual("Parameter containing:\ntensor([0.3000], dtype=torch.float64, requires_grad=True)", items[1].Item2.repr);
            Assert.AreEqual("a, b", string.Join(", ", dict.keys()));
            Assert.AreEqual("Parameter containing:\ntensor([0.5000], dtype=torch.float64, requires_grad=True)|Parameter containing:\ntensor([0.3000], dtype=torch.float64, requires_grad=True)", string.Join("|", dict.values().Select(v => v.repr)));
            Assert.AreEqual("a, b", string.Join(", ", dict.Select(x => x.Item1)));
            Assert.AreEqual("Parameter containing:\ntensor([0.5000], dtype=torch.float64, requires_grad=True)|Parameter containing:\ntensor([0.3000], dtype=torch.float64, requires_grad=True)", string.Join("|", dict.Select(x => x.Item2.repr)));
            Assert.AreEqual("Parameter containing:\ntensor([0.5000], dtype=torch.float64, requires_grad=True)", dict.pop("a").repr);
            Assert.AreEqual(1, dict.items().Count());
            dict.clear();
            Assert.AreEqual(0, dict.items().Count());
            dict.update(("a", a), ("b", b));
            Assert.AreEqual(2, dict.items().Count());
            Assert.AreEqual(2, dict.len());
        }

        [TestMethod]
        public void ParameterList()
        {
            var a = new torch.nn.Parameter( new[] { 0.5 });
            var b = new torch.nn.Parameter( new[] { 0.3 });
            var list = new torch.nn.ParameterList(a, b);
            Assert.AreEqual(a.repr, list[0].repr);
            Assert.AreNotEqual(a.repr, list[1].repr);
            Assert.AreEqual(b.repr, list[1].repr);
            Assert.Throws<PythonException>(() =>
            {
                var x = list[2];
            });
            Assert.AreEqual(2, list.Count());
            Assert.AreEqual("Parameter containing:\ntensor([0.5000], dtype=torch.float64, requires_grad=True)", list[0].repr);
            Assert.AreEqual("Parameter containing:\ntensor([0.3000], dtype=torch.float64, requires_grad=True)", list[1].repr);
            Assert.AreEqual("Parameter containing:\ntensor([0.5000], dtype=torch.float64, requires_grad=True)|Parameter containing:\ntensor([0.3000], dtype=torch.float64, requires_grad=True)", string.Join("|", list.Select(v => v.repr)));
            list.extend(b);
            Assert.AreEqual(3, list.Count());
            list.append(a);
            Assert.AreEqual(4, list.Count());
            Assert.AreEqual(4, list.len());
            Assert.AreEqual(new[] { a, b, b, a }.Select(x => x.repr).ToArray(), list.Select(x => x.repr).ToArray());
        }
    }
}
