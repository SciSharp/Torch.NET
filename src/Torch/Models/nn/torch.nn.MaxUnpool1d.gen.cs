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
            ///	Computes a partial inverse of MaxPool1d.<br></br>
            ///	
            ///	MaxPool1d is not fully invertible, since the non-maximal values are lost.<br></br>
            ///	
            ///	MaxUnpool1d takes in as input the output of MaxPool1d
            ///	including the indices of the maximal values and computes a partial inverse
            ///	in which all non-maximal values are set to zero.<br></br>
            ///	
            ///	Note
            ///	MaxPool1d can map several input sizes to the same output
            ///	sizes.<br></br>
            ///	 Hence, the inversion process can get ambiguous.<br></br>
            ///	
            ///	To accommodate this, you can provide the needed output size
            ///	as an additional argument output_size in the forward call.<br></br>
            ///	
            ///	See the Inputs and Example below.
            /// </summary>
            public partial class MaxUnpool1d : Module
            {
                // auto-generated class
                
                public MaxUnpool1d(PyObject pyobj) : base(pyobj) { }
                
                public MaxUnpool1d(Module other) : base(other.PyObject as PyObject) { }
                
                public MaxUnpool1d(int kernel_size, int stride = 1, int padding = 0)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                        kernel_size,
                    });
                    var kwargs=new PyDict();
                    if (stride!=1) kwargs["stride"]=ToPython(stride);
                    if (padding!=0) kwargs["padding"]=ToPython(padding);
                    dynamic py = __self__.InvokeMethod("MaxUnpool1d", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}
