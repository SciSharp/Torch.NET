using Python.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Numpy;
using Numpy.Models;


namespace Torch
{
    // note: this file contains manually overridden implementations
    public partial class PyTorch
    {

        public Tensor tensor(NDarray data, Dtype dtype = null, Device device = null, bool? requires_grad = false, bool? pin_memory = false)
        {
            var __self__ = self;
            var pyargs = ToTuple(new object[]
            {
                data.PyObject,
            });
            var kwargs = new PyDict();
            if (dtype != null) kwargs["dtype"] = ToPython(dtype);
            //if (layout != null) kwargs["layout"] = ToPython(layout);
            if (device != null) kwargs["device"] = ToPython(device);
            if (requires_grad != null) kwargs["requires_grad"] = ToPython(requires_grad);
            if (pin_memory != null) kwargs["pin_memory"] = ToPython(pin_memory);
            dynamic py = __self__.InvokeMethod("tensor", pyargs, kwargs);
            return ToCsharp<Tensor>(py);
        }

        public Tensor<T> tensor<T>(T[] data, Dtype dtype = null, Device device = null, bool? requires_grad = false, bool? pin_memory = false)
        {
            var type = data.GetDtype();
            var tensor = torch.empty(new Shape(data.Length), dtype: dtype ?? type, device: device,
                requires_grad: requires_grad, pin_memory: pin_memory);
            if (data.Length==0)
                return new Tensor<T>(tensor);
            var storage = tensor.PyObject.storage();
            long ptr = storage.data_ptr();
            switch ((object)data) {
                case byte[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case short[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case int[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case long[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case float[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case double[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
            }
            return new Tensor<T>( tensor);
        }

        public Tensor normal(Tensor mean, Tensor std, Tensor @out = null)
        {
            var __self__ = self;
            var pyargs = ToTuple(new object[]
            {
                mean,
                std,
            });
            var kwargs = new PyDict();
            if (@out != null) kwargs["out"] = ToPython(@out);
            dynamic py = __self__.InvokeMethod("normal", pyargs, kwargs);
            return ToCsharp<Tensor>(py);
        }

        public Tensor normal(float? mean, Tensor std, Tensor @out = null)
        {
            var __self__ = self;
            var pyargs = ToTuple(new object[]
            {
            });
            var kwargs = new PyDict();
            if (mean!=null && mean.Value != 0.0f) kwargs["mean"] = ToPython(mean);
            if (std != null) kwargs["std"] = ToPython(std);
            if (@out != null) kwargs["out"] = ToPython(@out);
            dynamic py = __self__.InvokeMethod("normal", pyargs, kwargs);
            return ToCsharp<Tensor>(py);
        }

        public Tensor normal(Tensor mean, float std = 1.0f, Tensor @out = null)
        {
            var __self__ = self;
            var pyargs = ToTuple(new object[]
            {
                mean,
            });
            var kwargs = new PyDict();
            if (std != 1.0) kwargs["std"] = ToPython(std);
            if (@out != null) kwargs["out"] = ToPython(@out);
            dynamic py = __self__.InvokeMethod("normal", pyargs, kwargs);
            return ToCsharp<Tensor>(py);
        }

        public void @add(Tensor input, object @value, Tensor @out = null)
        {
            var __self__ = self;
            var pyargs = ToTuple(new object[]
            {
                input,
                @value,
            });
            var kwargs = new PyDict();
            if (@out != null) kwargs["out"] = ToPython(@out);
            dynamic py = __self__.InvokeMethod("add", pyargs, kwargs);
        }

        public void @add(Tensor input, object @value, Tensor other, Tensor @out = null)
        {
            var __self__ = self;
            var pyargs = ToTuple(new object[]
            {
                input,
            });
            var kwargs = new PyDict();
            kwargs["value"] = ToPython(@value);
            kwargs["other"] = ToPython(other);
            if (@out != null) kwargs["out"] = ToPython(@out);
            dynamic py = __self__.InvokeMethod("add", pyargs, kwargs);
        }
    }
}
