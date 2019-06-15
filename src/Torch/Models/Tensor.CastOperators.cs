using System;
using System.Collections.Generic;
using System.Text;

namespace Torch
{
    public partial class Tensor
    {
        public static implicit operator Tensor(Array array)
        {
            if (array == null)
                return null;
            switch (array)
            {
                case byte[] a: return torch.tensor(a);
                case bool[] a: return torch.tensor(a);
                case short[] a: return torch.tensor(a);
                case int[] a: return torch.tensor(a);
                case long[] a: return torch.tensor(a);
                case float[] a: return torch.tensor(a);
                case double[] a: return torch.tensor(a);
                case byte[,] a: return torch.tensor(a);
                case bool[,] a: return torch.tensor(a);
                case short[,] a: return torch.tensor(a);
                case int[,] a: return torch.tensor(a);
                case long[,] a: return torch.tensor(a);
                case float[,] a: return torch.tensor(a);
                case double[,] a: return torch.tensor(a);
                case byte[,,] a: return torch.tensor(a);
                case bool[,,] a: return torch.tensor(a);
                case short[,,] a: return torch.tensor(a);
                case int[,,] a: return torch.tensor(a);
                case long[,,] a: return torch.tensor(a);
                case float[,,] a: return torch.tensor(a);
                case double[,,] a: return torch.tensor(a);
            }
            throw new InvalidOperationException($"Unable to cast {array.GetType()} to Tensor");
        }

        // these must be explicit or we have bad side effects
        public static explicit operator Tensor(bool d) => torch.as_tensor(d);
        public static explicit operator Tensor(byte d) => torch.as_tensor(d);
        public static explicit operator Tensor(short d) => torch.as_tensor(d);
        public static explicit operator Tensor(int d) => torch.as_tensor(d);
        public static explicit operator Tensor(long d) => torch.as_tensor(d);
        public static explicit operator Tensor(float d) => torch.as_tensor(d);
        public static explicit operator Tensor(double d) => torch.as_tensor(d);

        // these must be explicit or we have bad side effects
        public static explicit operator bool(Tensor a) => a.as_scalar<bool>();
        public static explicit operator byte(Tensor a) => a.as_scalar<byte>();
        public static explicit operator short(Tensor a) => a.as_scalar<short>();
        public static explicit operator int(Tensor a) => a.as_scalar<int>();
        public static explicit operator long(Tensor a) => a.as_scalar<long>();
        public static explicit operator float(Tensor a) => a.as_scalar<float>();
        public static explicit operator double(Tensor a) => a.as_scalar<double>();

    }
}
