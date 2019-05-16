using System;
using System.Collections.Generic;
using System.Text;
using Python.Runtime;

namespace Torch
{
    public class Tensor : IDisposable
    {

        private readonly PyObject _pyobject;
        public dynamic PyObject => _pyobject;

        public IntPtr Handle => _pyobject.Handle;
        public string Name { get; set; }

        public Tensor(PyObject pyobject)
        {
            this._pyobject = pyobject;
        }

        public override string ToString()
        {
            return _pyobject.ToString();
        }

        public void Dispose()
        {
            _pyobject?.Dispose();
        }
    }
}
