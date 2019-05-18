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
    public static partial class torch
    {
        
        public static Tensor empty(NumSharp.Shape sizes, Tensor @out = null, dtype dtype = null, layout layout = null, device device = null, bool? requires_grad = null, bool? pin_memory = null)
            => PyTorch.Instance.empty(sizes, @out:@out, dtype:dtype, layout:layout, device:device, requires_grad:requires_grad, pin_memory:pin_memory);
        
        
    }
}
