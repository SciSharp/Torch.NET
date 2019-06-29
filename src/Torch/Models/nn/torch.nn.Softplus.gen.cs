// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

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
            ///	Applies the element-wise function:
            ///	
            ///	\[\text{Softplus}(x) = \frac{1}{\beta} * \log(1 + \exp(\beta * x))
            ///	
            ///	\]
            ///	
            ///	SoftPlus is a smooth approximation to the ReLU function and can be used
            ///	to constrain the output of a machine to always be positive.<br></br>
            ///	
            ///	For numerical stability the implementation reverts to the linear function
            ///	for inputs above a certain value.
            /// </summary>
            public partial class Softplus : Module
            {
                // auto-generated class
                
                public Softplus(PyObject pyobj) : base(pyobj) { }
                
                public Softplus(Module other) : base(other.PyObject as PyObject) { }
                
                public Softplus(int beta = 1, double threshold = 20)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                    });
                    var kwargs=new PyDict();
                    if (beta!=1) kwargs["beta"]=ToPython(beta);
                    if (threshold!=20) kwargs["threshold"]=ToPython(threshold);
                    dynamic py = __self__.InvokeMethod("Softplus", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}