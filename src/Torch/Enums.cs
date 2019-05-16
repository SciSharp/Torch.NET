using System;
using System.Collections.Generic;
using System.Text;
using Python.Runtime;

namespace Torch
{
    public enum dtype
    {
        UInt8,
        Int8,
        Int16,
        Int32,
        Int64,
        Float32,
        Float64
    }

    public enum layout
    {
        Strided, // (dense)
        Sparse,
        Mkldnn,
    }

    public enum device
    {
        CPU,
        CUDA
    }


    public static class EnumExtensions
    {
        public static PyObject ToPython(this dtype value)
        {
            var torch = TorchRunner.Instance.torch;
            // todo: cache these values
            switch (value)
            {
                case dtype.UInt8: return (PyObject)torch.uint8;
                case dtype.Int8: return (PyObject)torch.int8;
                case dtype.Int16: return (PyObject)torch.int16;
                case dtype.Int32: return (PyObject)torch.int32;
                case dtype.Int64: return (PyObject)torch.int64;
                //case dtype.Float16: return (PyObject)torch.float16;
                case dtype.Float32: return (PyObject)torch.float32;
                case dtype.Float64: return (PyObject)torch.float64;
                default: throw new ArgumentException("Invalid dtype: " + value);
            }
        }
    }

}
