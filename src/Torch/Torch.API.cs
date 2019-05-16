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
            var args = ToTuple(new object[] {
                data,
            });
            var kwargs = new PyDict();
            if (dtype != null) kwargs["dtype"] = ToPython(dtype);
            if (device != null) kwargs["device"] = ToPython(device);
            if (requires_grad != null) kwargs["requires_grad"] = ToPython(requires_grad);
            if (pin_memory != null) kwargs["pin_memory"] = ToPython(pin_memory);
            dynamic py = torch.InvokeMethod("tensor", args);
            return ToCsharp<Tensor>(py);
        }

        public Tensor empty(NumSharp.Shape sizes, Tensor @out = null, dtype? dtype = null, layout? layout = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            //auto-generated code, do not change
            var args = ToTuple(new object[] {
                sizes,
            });
            var kwargs = new PyDict();
            if (@out != null) kwargs["out"] = ToPython(@out);
            if (dtype != null) kwargs["dtype"] = ToPython(dtype);
            if (layout != null) kwargs["layout"] = ToPython(layout);
            if (device != null) kwargs["device"] = ToPython(device);
            if (requires_grad != null) kwargs["requires_grad"] = ToPython(requires_grad);
            if (pin_memory != null) kwargs["pin_memory"] = ToPython(pin_memory);
            dynamic py = torch.InvokeMethod("empty", args, kwargs);
            return ToCsharp<Tensor>(py);
        }
    }
}
