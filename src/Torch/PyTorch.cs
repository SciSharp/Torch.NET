using Python.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NumSharp;


namespace Torch
{
    // note: this file contains manually overridden implementations
    public partial class PyTorch
    {

        public Tensor tensor(NumSharp.NDArray data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            // note: this implementation works only for device CPU
            // todo: implement for GPU
            var type = data.dtype.ToDtype();
            if (dtype != null && type != dtype)
                throw new NotImplementedException("Type of the array is different from specified dtype. Data conversion is not supported (yet)");
            var tensor = torch.empty((Shape)data.shape, dtype: type, device: device,
                requires_grad: requires_grad, pin_memory: pin_memory);
            var storage = tensor.PyObject.storage();
            long ptr = storage.data_ptr();
            switch (type)
            {
                case Torch.dtype.UInt8: Marshal.Copy(data.Data<byte>(), 0, new IntPtr(ptr), data.len); break;
                case Torch.dtype.Int32: Marshal.Copy(data.Data<int>(), 0, new IntPtr(ptr), data.len); break;
                case Torch.dtype.Int64: Marshal.Copy(data.Data<long>(), 0, new IntPtr(ptr), data.len); break;
                case Torch.dtype.Float32: Marshal.Copy(data.Data<float>(), 0, new IntPtr(ptr), data.len); break;
                case Torch.dtype.Float64: Marshal.Copy(data.Data<double>(), 0, new IntPtr(ptr), data.len); break;
            }
            return tensor;
        }

        public Tensor<T> tensor<T>(T[] data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            // note: this implementation works only for device CPU
            // todo: implement for GPU
            var type = data.GetDtype();
            if (dtype!=null && type!=dtype)
                throw new NotImplementedException("Type of the array is different from specified dtype. Data conversion is not supported (yet)");
            var tensor = torch.empty(new Shape(data.Length), dtype: type, device: device,
                requires_grad: requires_grad, pin_memory: pin_memory);
            var storage = tensor.PyObject.storage();
            long ptr = storage.data_ptr();
            switch ((object)data) {
                case byte[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case short[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case int[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case long[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case float[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case double[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
            }
            return new Tensor<T>( tensor);
        }

        //public Tensor<T> tensor<T>(T[,] data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        //{
        //    // note: this implementation works only for device CPU
        //    // todo: implement for GPU
        //    var type = data.GetDtype();
        //    if (dtype != null && type != dtype)
        //        throw new NotImplementedException("Type of the array is different from specified dtype. Data conversion is not supported (yet)");
        //    var tensor = empty(new Shape(data.Length), dtype: type, device: device,
        //        requires_grad: requires_grad, pin_memory: pin_memory);
        //    var storage = tensor.PyObject.storage();
        //    long ptr = storage.data_ptr();
        //    switch ((object)data)
        //    {
        //        case byte[,] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
        //        case short[,] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
        //        case int[,] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
        //        case long[,] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
        //        case float[,] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
        //        case double[,] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
        //    }
        //    return new Tensor<T>(tensor);
        //}

    }
}
