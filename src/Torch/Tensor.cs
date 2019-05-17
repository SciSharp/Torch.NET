using System;
using System.Collections.Generic;
using System.Text;
using Python.Runtime;

namespace Torch
{
    public partial class Tensor : IDisposable
    {

        protected readonly PyObject _pobj;
        public dynamic PyObject => _pobj;

        public IntPtr Handle => _pobj.Handle;
        public string Name { get; set; }

        public Tensor(PyObject pyobject)
        {
            this._pobj = pyobject;
        }

        public Tensor(Tensor t)
        {
            this._pobj = t.PyObject;
        }

        public override string ToString()
        {
            return _pobj.ToString();
        }

        public void Dispose()
        {
            _pobj?.Dispose();
        }
    }

    public partial class Tensor<T> : Tensor
    {
        public Tensor(Tensor t) : base(t)
        {
        }

        public Tensor(PyObject pyobject) : base(pyobject)
        {
        }
    }
}
