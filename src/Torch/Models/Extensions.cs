using System;
using System.Collections.Generic;
using System.Text;
using Python.Runtime;

namespace Torch
{
    public static class TorchExtensions
    {
        public static Dtype GetDtype(this object obj)
        {
            switch (obj)
            {
                case bool o: return torch.uint8;
                case byte o: return torch.uint8;
                case short o: return torch.int16;
                case int o: return torch.int32;
                case long o: return torch.int64;
                case float o: return torch.float32;
                case double o: return torch.float64;
                case bool[] o: return torch.uint8;
                case byte[] o: return torch.uint8;
                case short[] o: return torch.int16;
                case int[] o: return torch.int32;
                case long[] o: return torch.int64;
                case float[] o: return torch.float32;
                case double[] o: return torch.float64;
                case bool[,] o: return torch.uint8;
                case byte[,] o: return torch.uint8;
                case short[,] o: return torch.int16;
                case int[,] o: return torch.int32;
                case long[,] o: return torch.int64;
                case float[,] o: return torch.float32;
                case double[,] o: return torch.float64;
                case bool[,,] o: return torch.uint8;
                case byte[,,] o: return torch.uint8;
                case short[,,] o: return torch.int16;
                case int[,,] o: return torch.int32;
                case long[,,] o: return torch.int64;
                case float[,,] o: return torch.float32;
                case double[,,] o: return torch.float64;
                default: throw new ArgumentException("Can not convert type of given object to dtype: " + obj.GetType());
            }
        }

        public static Dtype ToDtype(this Type t)
        {
            if (t == typeof(bool)) return torch.uint8;
            if (t == typeof(byte)) return torch.uint8;
            if (t == typeof(short)) return torch.int16;
            if (t == typeof(int)) return torch.int32;
            if (t == typeof(long)) return torch.int64;
            if (t == typeof(float)) return torch.float32;
            if (t == typeof(double)) return torch.float64;
            throw new ArgumentException("Can not convert given type to dtype: " + t);
        }
    }

}
