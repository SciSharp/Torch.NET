using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Torch
{
    internal class c_api
    {
        [DllImport("torch")]
        internal extern static IntPtr empty(int[] dims);

        [DllImport("caffe2")]
        internal extern static IntPtr THFloatTensor_newWithSize1d(long size0);
    }
}
