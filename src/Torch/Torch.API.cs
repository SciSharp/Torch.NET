using Python.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Torch
{
    public partial class TorchRunner
    {
        public Tensor tensor(NumSharp.NDArray data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            //auto-generated code, do not change
            var _data = Util.ToPython(data);
            var _dtype = Util.ToPython(dtype);
            var _device = Util.ToPython(device);
            var _requires_grad = Util.ToPython(requires_grad);
            var _pin_memory = Util.ToPython(pin_memory);
            dynamic py = torch.tensor(_data, _dtype, _device, _requires_grad, _pin_memory);
            return Util.ToCsharp<Tensor>(py);
        }

        public Tensor empty(NumSharp.Shape sizes, Tensor @out = null, dtype? dtype = null, layout? layout = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            //auto-generated code, do not change
            var _sizes = Util.ToPython(sizes);
            var _out = Util.ToPython(@out);
            var _dtype = Util.ToPython(dtype);
            var _layout = Util.ToPython(layout);
            var _device = Util.ToPython(device);
            var _requires_grad = Util.ToPython(requires_grad);
            var _pin_memory = Util.ToPython(pin_memory);
            dynamic py = torch.empty(_sizes, _out, _dtype, _layout, _device, _requires_grad, _pin_memory);
            return Util.ToCsharp<Tensor>(py);
        }
    }
}
