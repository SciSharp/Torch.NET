using System;
using System.Runtime.InteropServices;

namespace Torch
{
    public static class torch
    {
        public static void empty(params int[] dims)
        {
            c_api.THFloatTensor_newWithSize1d(1);
        }
    }
}
