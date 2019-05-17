using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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

        /// <summary>
        /// Returns a copy of the tensor data
        /// </summary>
        public T[] GetData()
        {
            // note: this implementation works only for device CPU
            // todo: implement for GPU
            var storage = PyObject.storage();
            long ptr = storage.data_ptr();
            int size = storage.size();
            object array=null;
            if (typeof(T) == typeof(byte)) array = new byte[size];
            else if (typeof(T) == typeof(short)) array = new short[size];
            else if (typeof(T) == typeof(int)) array = new int[size];
            else if (typeof(T) == typeof(long)) array = new long[size];
            else if (typeof(T) == typeof(float)) array = new float[size];
            else if (typeof(T) == typeof(double)) array = new double[size];
            switch (array)
            {
                case byte[] a: Marshal.Copy(new IntPtr(ptr), a, 0, a.Length); break;
                case short[] a: Marshal.Copy(new IntPtr(ptr), a, 0, a.Length); break;
                case int[] a: Marshal.Copy(new IntPtr(ptr), a, 0, a.Length); break;
                case long[] a: Marshal.Copy(new IntPtr(ptr), a, 0, a.Length); break;
                case float[] a: Marshal.Copy(new IntPtr(ptr), a, 0, a.Length); break;
                case double[] a: Marshal.Copy(new IntPtr(ptr), a, 0, a.Length); break;
            }
            return (T[])array;
        }
    }
}
