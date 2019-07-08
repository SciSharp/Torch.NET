using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy;
using Numpy.Models;

namespace Torch
{
    // note: this file contains manually overridden API functions
    public static partial class torch
    {

        public static Tensor tensor(NDarray data, Dtype dtype = null, Device device = null, bool requires_grad = false, bool pin_memory = false)
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

        public static Tensor<T> tensor<T>(T[] data, Dtype dtype = null, Device device = null, bool requires_grad = false, bool pin_memory = false)
        {
            var type = data.GetDtype();
            var tensor = torch.empty(new Shape(data.Length), dtype: dtype ?? type, device: device,
                requires_grad: requires_grad, pin_memory: pin_memory);
            if (data.Length == 0)
                return new Tensor<T>(tensor);
            var storage = tensor.PyObject.storage();
            long ptr = storage.data_ptr();
            switch ((object)data)
            {
                case byte[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case short[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case int[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case long[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case float[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case double[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
            }
            return new Tensor<T>(tensor);
        }

        /// <summary>
        /// retrun a Tensor from a scalar value
        /// </summary>
        public static Tensor<T> as_tensor<T>(T scalar, Dtype dtype = null, Device device = null)
        {
            var self = torch.self;
            var pyargs = torch.ToTuple(new object[] { scalar });
            var kwargs = new PyDict();
            if (dtype != null) kwargs["dtype"] = torch.ToPython(dtype);
            if (device != null) kwargs["device"] = torch.ToPython(device);
            return new Tensor<T>(self.InvokeMethod("as_tensor", pyargs, kwargs));
        }

        public static Tensor<T> as_tensor<T>(T[] data, Dtype dtype = null, Device device = null)
        {
            return tensor(data, dtype, device);
        }

        // layouts
        public static Layout strided => new Layout(torch.self.GetAttr("strided"));
        public static Layout sparse_coo => new Layout(torch.self.GetAttr("sparse_coo"));

        // dtypes
        public static Dtype float32 => new Dtype(torch.self.GetAttr("float32"));
        public static Dtype @float => new Dtype(torch.self.GetAttr("float"));
        public static Dtype float64 => new Dtype(torch.self.GetAttr("float64"));
        public static Dtype @double => new Dtype(torch.self.GetAttr("double"));
        public static Dtype float16 => new Dtype(torch.self.GetAttr("float16"));
        public static Dtype half => new Dtype(torch.self.GetAttr("half"));
        public static Dtype uint8 => new Dtype(torch.self.GetAttr("uint8"));
        public static Dtype int8 => new Dtype(torch.self.GetAttr("int8"));
        public static Dtype int16 => new Dtype(torch.self.GetAttr("int16"));
        public static Dtype @short => new Dtype(torch.self.GetAttr("short"));
        public static Dtype int32 => new Dtype(torch.self.GetAttr("int32"));
        public static Dtype @int => new Dtype(torch.self.GetAttr("int"));
        public static Dtype int64 => new Dtype(torch.self.GetAttr("int64"));
        public static Dtype @long => new Dtype(torch.self.GetAttr("long"));
        public static Dtype FloatTensor => new Dtype(torch.self.GetAttr("FloatTensor"));
        public static Dtype DoubleTensor => new Dtype(torch.self.GetAttr("DoubleTensor"));
        public static Dtype IntTensor => new Dtype(torch.self.GetAttr("IntTensor"));
        public static Dtype LongTensor => new Dtype(torch.self.GetAttr("LongTensor"));
        public static Dtype ByteTensor => new Dtype(torch.self.GetAttr("ByteTensor"));

        // Locally disabling gradient computation
        public static PyObject no_grad() => autograd.no_grad();
        public static PyObject enable_grad() => autograd.enable_grad();
        public static PyObject set_grad_enabled(bool mode) => autograd.set_grad_enabled(mode);
        public static partial class autograd
        {
            public static PyObject no_grad() => dynamic_self.no_grad();
            public static PyObject enable_grad() => dynamic_self.enable_grad();
            public static PyObject set_grad_enabled(bool mode) => dynamic_self.enable_grad(mode);
        }

        /// <summary>
        /// A torch.device is an object representing the device on which a torch.Tensor is or will be allocated.
        /// 
        /// The torch.device contains a device type ('cpu' or 'cuda') and optional device ordinal for the device type.
        /// If the device ordinal is not present, this represents the current device for the device type; e.g.a torch.
        /// Tensor constructed with device 'cuda' is equivalent to 'cuda:X' where X is the result of
        /// torch.cuda.current_device().
        /// 
        /// A torch.Tensor’s device can be accessed via the Tensor.device property.
        /// A torch.device can be constructed via a string or via a string and device ordinal
        /// </summary>
        /// <param name="name">Any of cpu, cuda, mkldnn, opengl, opencl, ideep, hip, msnpu</param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static Device device(string name, int? index=null)
        {
            if (index==null)
                return new Device(torch.self.InvokeMethod("device", torch.ToTuple(new object[]{name})));
            return new Device(torch.self.InvokeMethod("device", torch.ToTuple(new object[] { name, index.Value })));
        }

        /// <summary>
        /// Return a cuda device
        /// </summary>
        public static Device device(int index)
        {
            return new Device(torch.self.InvokeMethod("device", torch.ToTuple(new object[] { index})));
        }

        /// <summary>
        /// Returns a tensor of random numbers drawn from separate normal distributions whose mean
        /// and standard deviation are given.
        /// 
        /// The shapes of mean and std don’t need to match, but the total number of elements in each tensor need to be the same.
        /// 
        /// NOTE: When the shapes do not match, the shape of mean is used as the shape for the returned output tensor
        /// </summary>
        /// <param name="mean">The mean is a tensor with the mean of each output element’s normal distribution</param>
        /// <param name="std">The std is a tensor with the standard deviation of each output element’s normal distribution</param>
        /// <param name="out">The output tensor</param>
        /// <returns></returns>
        public static Tensor normal(Tensor mean, Tensor std, Tensor @out = null)
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

        /// <summary>
        /// Returns a tensor of random numbers drawn from separate normal distributions whose mean
        /// and standard deviation are given.
        /// </summary>
        /// <param name="mean">The mean for all distributions (default: 0 if null)</param>
        /// <param name="std">The std is a tensor with the standard deviation of each output element’s normal distribution</param>
        /// <param name="out">The output tensor</param>
        /// <returns></returns>
        public static Tensor normal(float? mean, Tensor std, Tensor @out = null)
        {
            var __self__ = self;
            var pyargs = ToTuple(new object[]
            {
            });
            var kwargs = new PyDict();
            if (mean != null && mean.Value != 0.0f) kwargs["mean"] = ToPython(mean);
            if (std != null) kwargs["std"] = ToPython(std);
            if (@out != null) kwargs["out"] = ToPython(@out);
            dynamic py = __self__.InvokeMethod("normal", pyargs, kwargs);
            return ToCsharp<Tensor>(py);
        }

        /// <summary>
        /// Returns a tensor of random numbers drawn from separate normal distributions whose mean
        /// and standard deviation are given.
        /// </summary>
        /// <param name="mean">The mean is a tensor with the mean of each output element’s normal distribution</param>
        /// <param name="std">The standard deviation for all distributions</param>
        /// <param name="out">The output tensor</param>
        /// <returns></returns>
        public static Tensor normal(Tensor mean, float std = 1.0f, Tensor @out = null)
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

        /// <summary>
        /// Adds the scalar value to each element of the input input and returns a new resulting tensor.
        /// 
        /// out=input+value
        /// If input is of type FloatTensor or DoubleTensor, value must be a real number, otherwise it should be an integer.
        /// </summary>
        /// <param name="input">the input tensor</param>
        /// <param name="@value">the number to be added to each element of input</param>
        /// <param name="out"> the output tensor</param>
        public static void @add(Tensor input, object @value, Tensor @out = null)
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

        /// <summary>
        /// Each element of the tensor other is multiplied by the scalar value and added to each element of the tensor input.
        /// The resulting tensor is returned. The shapes of input and other must be broadcastable.
        /// 
        /// out=input+value×other
        /// If other is of type FloatTensor or DoubleTensor, value must be a real number, otherwise it should be an integer.
        /// </summary>
        /// <param name="input">the first input tensor</param>
        /// <param name="value">the scalar multiplier for other</param>
        /// <param name="other">the second input tensor</param>
        /// <param name="out">the output tensor</param>
        public static void @add(Tensor input, object @value, Tensor other, Tensor @out = null)
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

        /// <summary>
        /// Each element of the tensor other added to each element of the tensor input.
        /// The resulting tensor is returned. The shapes of input and other must be broadcastable.
        /// 
        /// out=input+other
        /// </summary>
        /// <param name="input">the first input tensor</param>
        /// <param name="other">the second input tensor</param>
        /// <param name="out">the output tensor</param>
        public static void @add(Tensor input, Tensor other, Tensor @out = null)
            => torch.@add(input, @value: 1, other: other, @out: @out);

        /// <summary>
        /// Returns a tensor filled with random numbers from a uniform distribution
        /// on the interval \([0, 1)\)
        /// 
        /// The shape of the tensor is defined by the variable argument sizes.
        /// </summary>
        /// <param name="sizes">
        /// a sequence of integers defining the shape of the output tensor.
        /// Can be a variable number of arguments or a collection like a list or tuple.
        /// </param>
        public static Tensor rand(params int[] sizes)
            => torch.rand(new Shape(sizes));

        /// <summary>
        /// Returns a tensor filled with random numbers from a normal distribution
        /// with mean 0 and variance 1 (also called the standard normal
        /// distribution).
        /// 
        /// \[\text{out}_{i} \sim \mathcal{N}(0, 1)
        /// 
        /// \]
        /// 
        /// The shape of the tensor is defined by the variable argument sizes.
        /// </summary>
        /// <param name="sizes">
        /// a sequence of integers defining the shape of the output tensor.
        /// Can be a variable number of arguments or a collection like a list or tuple.
        /// </param>
        public static Tensor randn(params int[] sizes)
            => torch.randn(new Shape(sizes));

        /// <summary>
        /// Returns a tensor filled with the scalar value 0, with the shape defined
        /// by the variable argument sizes.
        /// </summary>
        /// <param name="sizes">
        /// a sequence of integers defining the shape of the output tensor.
        /// Can be a variable number of arguments or a collection like a list or tuple.
        /// </param>
        public static Tensor zeros(params int[] sizes)
            => torch.zeros(new Shape(sizes));

        /// <summary>
        /// Returns a tensor filled with the scalar value 1, with the shape defined
        /// by the variable argument sizes.
        /// </summary>
        /// <param name="sizes">
        /// a sequence of integers defining the shape of the output tensor.
        /// Can be a variable number of arguments or a collection like a list or tuple.
        /// </param>
        public static Tensor ones(params int[] sizes)
            => torch.ones(new Shape(sizes));


        /// <summary>
        /// Returns a tensor filled with uninitialized data. The shape of the tensor is
        /// defined by the variable argument sizes.
        /// </summary>
        /// <param name="sizes">
        /// a sequence of integers defining the shape of the output tensor.
        /// Can be a variable number of arguments or a collection like a list or tuple.
        /// </param>
        public static Tensor empty(params int[] sizes)
            => torch.empty(new Shape(sizes));

        /// <summary>
        /// Returns a 1-D tensor of size \(\left\lfloor \frac{\text{end} - \text{start}}{\text{step}} \right\rfloor\)
        /// with values from the interval [start, end) taken with common difference
        /// step beginning from start.
        /// 
        /// Note that non-integer step is subject to floating point rounding errors when
        /// comparing against end; to avoid inconsistency, we advise adding a small epsilon to end
        /// in such cases.
        /// 
        /// \[\text{out}_{{i+1}} = \text{out}_{i} + \text{step}
        /// 
        /// \]
        /// </summary>
        /// <param name="start">
        /// the starting value for the set of points. Default: 0.
        /// </param>
        /// <param name="end">
        /// the ending value for the set of points
        /// </param>
        /// <param name="step">
        /// the gap between each pair of adjacent points. Default: 1.
        /// </param>
        /// <param name="@out">
        /// the output tensor
        /// </param>
        /// <param name="dtype">
        /// the desired data type of returned tensor.
        /// Default: if None, uses a global default (see torch.set_default_tensor_type()). If dtype is not given, infer the data type from the other input
        /// arguments. If any of start, end, or stop are floating-point, the
        /// dtype is inferred to be the default dtype, see
        /// get_default_dtype(). Otherwise, the dtype is inferred to
        /// be torch.int64.
        /// </param>
        /// <param name="layout">
        /// the desired layout of returned Tensor.
        /// Default: torch.strided.
        /// </param>
        /// <param name="device">
        /// the desired device of returned tensor.
        /// Default: if None, uses the current device for the default tensor type
        /// (see torch.set_default_tensor_type()). device will be the CPU
        /// for CPU tensor types and the current CUDA device for CUDA tensor types.
        /// </param>
        /// <param name="requires_grad">
        /// If autograd should record operations on the
        /// returned tensor. Default: False.
        /// </param>
        public static Tensor arange(int start, int end, int step = 1, Tensor @out = null, Dtype dtype = null, Layout layout = null, Device device = null, bool? requires_grad = false)
            => torch.arange(start, end, step: step, @out: @out, dtype: torch.int64, layout: layout, device: device, requires_grad: requires_grad);

        /// <summary>
        /// Returns a 1-D tensor of size \(\left\lfloor \frac{\text{end} - \text{start}}{\text{step}} \right\rfloor\)
        /// with values from the interval [start, end) taken with common difference
        /// step beginning from start.
        /// 
        /// Note that non-integer step is subject to floating point rounding errors when
        /// comparing against end; to avoid inconsistency, we advise adding a small epsilon to end
        /// in such cases.
        /// 
        /// \[\text{out}_{{i+1}} = \text{out}_{i} + \text{step}
        /// 
        /// \]
        /// </summary>
        /// <param name="end">
        /// the ending value for the set of points
        /// </param>
        /// <param name="@out">
        /// the output tensor
        /// </param>
        /// <param name="dtype">
        /// the desired data type of returned tensor.
        /// Default: if None, uses a global default (see torch.set_default_tensor_type()). If dtype is not given, infer the data type from the other input
        /// arguments. If any of start, end, or stop are floating-point, the
        /// dtype is inferred to be the default dtype, see
        /// get_default_dtype(). Otherwise, the dtype is inferred to
        /// be torch.int64.
        /// </param>
        /// <param name="layout">
        /// the desired layout of returned Tensor.
        /// Default: torch.strided.
        /// </param>
        /// <param name="device">
        /// the desired device of returned tensor.
        /// Default: if None, uses the current device for the default tensor type
        /// (see torch.set_default_tensor_type()). device will be the CPU
        /// for CPU tensor types and the current CUDA device for CUDA tensor types.
        /// </param>
        /// <param name="requires_grad">
        /// If autograd should record operations on the
        /// returned tensor. Default: False.
        /// </param>
        public static Tensor arange(int end, Tensor @out = null, Dtype dtype = null, Layout layout = null, Device device = null, bool? requires_grad = false)
            => torch.arange(0, end, 1, @out: @out, dtype: torch.int64, layout: layout, device: device, requires_grad: requires_grad);

        /// <summary>
        /// Clamp all elements in input into the range [ min, max ] and return
        /// a resulting tensor:
        /// 
        /// \[y_i = \begin{cases}
        ///     \text{min} & \text{if } x_i < \text{min} \\
        ///     x_i & \text{if } \text{min} \leq x_i \leq \text{max} \\
        ///     \text{max} & \text{if } x_i > \text{max}
        /// \end{cases}
        /// 
        /// \]
        /// 
        /// If input is of type FloatTensor or DoubleTensor, args min
        /// and max must be real numbers, otherwise they should be integers.
        /// </summary>
        /// <param name="input">
        /// the input tensor
        /// </param>
        /// <param name="min">
        /// lower-bound of the range to be clamped to
        /// </param>
        /// <param name="max">
        /// upper-bound of the range to be clamped to
        /// </param>
        /// <param name="out">
        /// the output tensor
        /// </param>
        public static Tensor clamp(Tensor input, double? min = null, double? max = null, Tensor @out = null)
        {
            //auto-generated code, do not change
            var __self__ = self;
            var pyargs = ToTuple(new object[]
            {
                input,
            });
            var kwargs = new PyDict();
            if (min != null) kwargs["min"] = ToPython(min);
            if (max != null) kwargs["max"] = ToPython(max);
            if (@out != null) kwargs["out"] = ToPython(@out);
            dynamic py = __self__.InvokeMethod("clamp", pyargs, kwargs);
            return ToCsharp<Tensor>(py);
        }
    }
}

