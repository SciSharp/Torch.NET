using System;
using System.Collections.Generic;
using System.Text;

namespace Torch
{
    public enum Layout
    {
        Strided, // (dense)
        Sparse,
        Mkldnn,
    }

    public enum ScalarType
    {
        UInt8, Int8, Int16, Int32, Int64, Float32, Float64
    }

    public enum Device
    {
        CPU, CUDA
    }

}
