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
    public static partial class torch {
        public static partial class nn {
            /// <summary>
            /// A sequential container.
            /// Modules will be added to it in the order they are passed in the constructor.
            /// Alternatively, an ordered dict of modules can also be passed in.
            /// 
            /// To make it easier to understand, here is a small example:
            /// 
            /// # Example of using Sequential
            /// model = nn.Sequential(
            ///           nn.Conv2d(1,20,5),
            ///           nn.ReLU(),
            ///           nn.Conv2d(20,64,5),
            ///           nn.ReLU()
            ///         )
            /// 
            /// # Example of using Sequential with OrderedDict
            /// model = nn.Sequential(OrderedDict([
            ///           (&#39;conv1&#39;, nn.Conv2d(1,20,5)),
            ///           (&#39;relu1&#39;, nn.ReLU()),
            ///           (&#39;conv2&#39;, nn.Conv2d(20,64,5)),
            ///           (&#39;relu2&#39;, nn.ReLU())
            ///         ]))
            /// </summary>
            public partial class Sequential : Module
            {
                public Sequential(PyObject pyobj) : base(pyobj) { }

                public Sequential(PythonObject other) : base(other.PyObject as PyObject) { }

                public Sequential(params PythonObject[] modules) : base()
                {
                    var nn = self.GetAttr("nn");
                    var __self__ = nn;
                    var pyargs = new PyTuple(modules.Select(m=>m.PyObject as PyObject).ToArray());
                    dynamic py = __self__.InvokeMethod("Sequential", pyargs);
                    self = py as PyObject;
                }

                public Sequential(params KeyValuePair<string, PythonObject>[] modules) : base()
                {
                    var nn = self.GetAttr("nn");
                    var __self__ = nn;
                    var tuples = modules.Select(pair =>
                            new PyTuple(new PyObject[] {new PyString(pair.Key), pair.Value.PyObject as PyObject})).ToArray();
                    var pyargs = new PyTuple(tuples);
                    dynamic py = __self__.InvokeMethod("Sequential", pyargs);
                    self = py as PyObject;
                }
            }
        }
    }
    
}
