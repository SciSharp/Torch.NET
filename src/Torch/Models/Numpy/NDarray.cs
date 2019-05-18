using System;
using System.Collections.Generic;
using System.Text;
using Python.Runtime;
using Torch.Models;

namespace Numpy
{
    public class NDarray : PythonObject
    {
        public NDarray(PyObject pyobj) : base(pyobj)
        {
        }

        public NDarray(NDarray t) : base((PyObject)t.PyObject)
        {
        }

    }
    
    public class NDarray<T> : NDarray
    {
        public NDarray(NDarray t) : base(t)
        {
        }

        public NDarray(PyObject pyobject) : base(pyobject)
        {
        }
    }
}
