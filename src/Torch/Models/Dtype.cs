using System;
using System.Collections.Generic;
using System.Text;
using Python.Runtime;

namespace Torch
{

    public partial class Dtype : PythonObject
    {
        public Dtype(PyObject pyobj) : base(pyobj)
        {
        }

        public bool is_floating_point => self.GetAttr("is_floating_point").As<bool>();

    }
}
