using Python.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NumSharp;


namespace Torch
{
    public partial class TorchRunner
    {
        //public Tensor tensor(NumSharp.NDArray data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        //{
        //    //auto-generated code, do not change
        //    var args = ToTuple(new object[] {
        //        data,
        //    });
        //    var kwargs = new PyDict();
        //    if (dtype != null) kwargs["dtype"] = ToPython(dtype);
        //    if (device != null) kwargs["device"] = ToPython(device);
        //    if (requires_grad != null) kwargs["requires_grad"] = ToPython(requires_grad);
        //    if (pin_memory != null) kwargs["pin_memory"] = ToPython(pin_memory);
        //    dynamic py = torch.InvokeMethod("tensor", args);
        //    return ToCsharp<Tensor>(py);
        //}

        public Tensor tensor(NumSharp.NDArray data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            throw new NotImplementedException("This data type is not yet implemented: NumSharp.NDArray");
        }

        public Tensor tensor(int[] data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            // note: this implementation works only for device CPU
            // todo: implement for GPU
            var tensor = empty(new Shape(data.Length), dtype: Torch.dtype.Int32, device: device,
                requires_grad: requires_grad, pin_memory: pin_memory);
            var storage = tensor.PyObject.storage();
            long ptr = storage.data_ptr();
            Marshal.Copy(data, 0, new IntPtr(ptr), data.Length);
            return tensor;
        }

        public Tensor tensor(int[,] data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            throw new NotImplementedException("This data type is not yet implemented: int[,]");
        }

        public Tensor tensor(int[,,] data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            throw new NotImplementedException("This data type is not yet implemented: int[,,]");
        }

        public Tensor tensor(int[,,,] data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            throw new NotImplementedException("This data type is not yet implemented: int[,,,]");
        }

        public Tensor tensor(int[][] data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            throw new NotImplementedException("This data type is not yet implemented: int[][]");
        }

        public Tensor tensor(int[][][] data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            throw new NotImplementedException("This data type is not yet implemented: int[][][]");
        }

        public Tensor tensor(float[] data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            // note: this implementation works only for device CPU
            // todo: implement for GPU
            var tensor = empty(new Shape(data.Length), dtype: Torch.dtype.Float32, device: device,
                requires_grad: requires_grad, pin_memory: pin_memory);
            var storage = tensor.PyObject.storage();
            long ptr = storage.data_ptr();
            Marshal.Copy(data, 0, new IntPtr(ptr), data.Length);
            return tensor;
        }

        public Tensor tensor(double[] data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            // note: this implementation works only for device CPU
            // todo: implement for GPU
            var tensor = empty(new Shape(data.Length), dtype: Torch.dtype.Float64, device: device,
                requires_grad: requires_grad, pin_memory: pin_memory);
            var storage = tensor.PyObject.storage();
            long ptr = storage.data_ptr();
            Marshal.Copy(data, 0, new IntPtr(ptr), data.Length);
            return tensor;
        }

        public Tensor tensor(byte[] data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            // note: this implementation works only for device CPU
            // todo: implement for GPU
            var tensor = empty(new Shape(data.Length), dtype: Torch.dtype.UInt8, device: device,
                requires_grad: requires_grad, pin_memory: pin_memory);
            var storage = tensor.PyObject.storage();
            long ptr = storage.data_ptr();
            Marshal.Copy(data, 0, new IntPtr(ptr), data.Length);
            return tensor;
        }

        public Tensor tensor(bool[] data, dtype? dtype = null, device? device = null, bool? requires_grad = null, bool? pin_memory = null)
        {
            throw new NotImplementedException("This data type is not yet implemented: bool[]");
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
