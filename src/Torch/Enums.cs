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
            var torch = PyTorch.Instance.self;
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

        public static dtype GetDtype(this object obj)
        {
            switch (obj)
            {
                case byte o: return dtype.UInt8;
                case short o: return dtype.Int16;
                case int o: return dtype.Int32;
                case long o: return dtype.Int64;
                case float o: return dtype.Float32;
                case double o: return dtype.Float64;
                case byte[] o: return dtype.UInt8;
                case short[] o: return dtype.Int16;
                case int[] o: return dtype.Int32;
                case long[] o: return dtype.Int64;
                case float[] o: return dtype.Float32;
                case double[] o: return dtype.Float64;
                case byte[,] o: return dtype.UInt8;
                case short[,] o: return dtype.Int16;
                case int[,] o: return dtype.Int32;
                case long[,] o: return dtype.Int64;
                case float[,] o: return dtype.Float32;
                case double[,] o: return dtype.Float64;
                case byte[,,] o: return dtype.UInt8;
                case short[,,] o: return dtype.Int16;
                case int[,,] o: return dtype.Int32;
                case long[,,] o: return dtype.Int64;
                case float[,,] o: return dtype.Float32;
                case double[,,] o: return dtype.Float64;
                default: throw new ArgumentException("Can not convert type of given object to dtype: " + obj.GetType());
            }
        }

        public static dtype ToDtype(this Type t)
        {
            if (t == typeof(byte)) return dtype.UInt8;
            if (t == typeof(short)) return dtype.Int16;
            if (t == typeof(int)) return dtype.Int32;
            if (t == typeof(long)) return dtype.Int64;
            if (t == typeof(float)) return dtype.Float32;
            if (t == typeof(double)) return dtype.Float64;
            throw new ArgumentException("Can not convert given type to dtype: " + t);
        }
    }

}
