using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using NumSharp;

namespace Torch
{
    // note: this file contains manually overridden API functions
    public static partial class torch
    {

        public static Tensor tensor(NumSharp.NDArray data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
            => PyTorch.Instance.tensor(data, dtype: dtype, device: device, requires_grad: requires_grad, pin_memory: pin_memory);

        public static Tensor<T> tensor<T>(T[] data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
            => PyTorch.Instance.tensor(data, dtype: dtype, device: device, requires_grad: requires_grad, pin_memory: pin_memory);


    }
}

