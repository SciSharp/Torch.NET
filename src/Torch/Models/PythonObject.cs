using System;
using System.Collections.Generic;
using System.Text;
using Python.Runtime;

namespace Torch.Models
{
    public class PythonObject : IDisposable
    {
        protected readonly PyObject _pobj;
        public dynamic PyObject => _pobj;

        public IntPtr Handle => _pobj.Handle;

        public PythonObject(PyObject pyobject)
        {
            this._pobj = pyobject;
        }

        public PythonObject(Tensor t)
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
}
