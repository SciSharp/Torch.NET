using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy;
using Numpy.Models;

namespace Torch
{
    public static partial class torch
    {
        public static partial class nn
        {
            /// <summary>
            ///	Holds submodules in a list.<br></br>
            ///	
            ///	
            ///	ModuleList can be indexed like a regular Python list, but
            ///	modules it contains are properly registered, and will be visible by all
            ///	Module methods.<br></br>
            ///	
            /// </summary>
            public partial class ModuleList : PythonObject, IEnumerable<Module>
            {

                public ModuleList(PyObject pyobj) : base(pyobj) { }

                public ModuleList(PythonObject other) : base(other.PyObject as PyObject) { }

                public ModuleList(params Module[] modules)
                {
                    var nn = self.GetAttr("nn");
                    var __self__ = nn;
                    var pyargs = ToTuple(new object[]
                    {
                    });
                    var kwargs = new PyDict();
                    if (modules != null) kwargs["modules"] = ToPython(modules);
                    dynamic py = __self__.InvokeMethod("ModuleList", pyargs, kwargs);
                    self = py as PyObject;
                }

                /// <summary>
                ///	Appends a given module to the end of the list.<br></br>
                ///	
                /// </summary>
                public void append(nn.Module module)
                {
                    var __self__ = self;
                    var pyargs = ToTuple(new object[]
                    {
                        module,
                    });
                    var kwargs = new PyDict();
                    dynamic py = __self__.InvokeMethod("append", pyargs, kwargs);
                }

                /// <summary>
                ///	Appends modules from a Python iterable to the end of the list.<br></br>
                ///	
                /// </summary>
                public void extend(params Module[] modules)
                {
                    var __self__ = self;
                    var pyargs = ToTuple(new object[]
                    {
                        modules,
                    });
                    var kwargs = new PyDict();
                    dynamic py = __self__.InvokeMethod("extend", pyargs, kwargs);
                }

                /// <summary>
                ///	Insert a given module before a given index in the list.<br></br>
                ///	
                /// </summary>
                /// <param name="index">
                ///	index to insert.<br></br>
                ///	
                /// </param>
                /// <param name="module">
                ///	module to insert
                /// </param>
                public void insert(int index, nn.Module module)
                {
                    var __self__ = self;
                    var pyargs = ToTuple(new object[]
                    {
                        index,
                        module,
                    });
                    var kwargs = new PyDict();
                    dynamic py = __self__.InvokeMethod("insert", pyargs, kwargs);
                }

                public int len()
                {
                    return self.InvokeMethod("__len__").As<int>();
                }

                public Module this[int index]
                {
                    get { return new Module(self.GetItem(index)); }
                }

                public IEnumerator<Module> GetEnumerator()
                {
                    foreach (PyObject m in self)
                        yield return new Module(m);
                }

                IEnumerator IEnumerable.GetEnumerator()
                {
                    return GetEnumerator();
                }
            }
        }
    }

}
