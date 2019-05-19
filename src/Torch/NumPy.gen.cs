using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using NumSharp;

namespace Numpy
{
    public partial class NumPy
    {
        
        /// <summary>
        /// Return a new array of given shape and type, without initializing entries.
        /// 
        /// Notes
        /// 
        /// empty, unlike zeros, does not set the array values to zero,
        /// and may therefore be marginally faster.  On the other hand, it requires
        /// the user to manually set all the values in the array, and should be
        /// used with caution.
        /// </summary>
        public NDarray empty(NumSharp.Shape shape, Dtype? dtype = null, string order = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                shape,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = self.InvokeMethod("empty", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return a new array with the same shape and type as a given array.
        /// 
        /// Notes
        /// 
        /// This function does not initialize the returned array; to do that use
        /// zeros_like or ones_like instead.  It may be marginally faster than
        /// the functions that do set the array values.
        /// </summary>
        public NDarray empty_like(NDarray prototype, Dtype? dtype = null, string order = null, bool? subok = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                prototype,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            if (subok!=null) kwargs["subok"]=ToPython(subok);
            dynamic py = self.InvokeMethod("empty_like", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return a new array with the same shape and type as a given array.
        /// 
        /// Notes
        /// 
        /// This function does not initialize the returned array; to do that use
        /// zeros_like or ones_like instead.  It may be marginally faster than
        /// the functions that do set the array values.
        /// </summary>
        public NDarray<T> empty_like<T>(T[] prototype, Dtype? dtype = null, string order = null, bool? subok = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                prototype,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            if (subok!=null) kwargs["subok"]=ToPython(subok);
            dynamic py = self.InvokeMethod("empty_like", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /// <summary>
        /// Return a 2-D array with ones on the diagonal and zeros elsewhere.
        /// </summary>
        public NDarray eye(int N, int? M = null, int? k = null, Dtype? dtype = null, string order = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                N,
            });
            var kwargs=new PyDict();
            if (M!=null) kwargs["M"]=ToPython(M);
            if (k!=null) kwargs["k"]=ToPython(k);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = self.InvokeMethod("eye", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return the identity array.
        /// 
        /// The identity array is a square array with ones on
        /// the main diagonal.
        /// </summary>
        public NDarray identity(int n, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                n,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("identity", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return a new array of given shape and type, filled with ones.
        /// </summary>
        public NDarray ones(NumSharp.Shape shape, Dtype? dtype = null, string order = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                shape,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = self.InvokeMethod("ones", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return an array of ones with the same shape and type as a given array.
        /// </summary>
        public NDarray ones_like(NDarray a, Dtype? dtype = null, string order = null, bool? subok = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            if (subok!=null) kwargs["subok"]=ToPython(subok);
            dynamic py = self.InvokeMethod("ones_like", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return an array of ones with the same shape and type as a given array.
        /// </summary>
        public NDarray<T> ones_like<T>(T[] a, Dtype? dtype = null, string order = null, bool? subok = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            if (subok!=null) kwargs["subok"]=ToPython(subok);
            dynamic py = self.InvokeMethod("ones_like", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /// <summary>
        /// Return a new array of given shape and type, filled with zeros.
        /// </summary>
        public NDarray zeros(NumSharp.Shape shape, Dtype? dtype = null, string order = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                shape,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = self.InvokeMethod("zeros", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return an array of zeros with the same shape and type as a given array.
        /// </summary>
        public NDarray zeros_like(NDarray a, Dtype? dtype = null, string order = null, bool? subok = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            if (subok!=null) kwargs["subok"]=ToPython(subok);
            dynamic py = self.InvokeMethod("zeros_like", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return an array of zeros with the same shape and type as a given array.
        /// </summary>
        public NDarray<T> zeros_like<T>(T[] a, Dtype? dtype = null, string order = null, bool? subok = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            if (subok!=null) kwargs["subok"]=ToPython(subok);
            dynamic py = self.InvokeMethod("zeros_like", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /// <summary>
        /// Return a new array of given shape and type, filled with fill_value.
        /// </summary>
        public NDarray full(NumSharp.Shape shape, ValueType fill_value, Dtype? dtype = null, string order = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                shape,
                fill_value,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = self.InvokeMethod("full", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return a full array with the same shape and type as a given array.
        /// </summary>
        public NDarray full_like(NDarray a, ValueType fill_value, Dtype? dtype = null, string order = null, bool? subok = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
                fill_value,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            if (subok!=null) kwargs["subok"]=ToPython(subok);
            dynamic py = self.InvokeMethod("full_like", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return a full array with the same shape and type as a given array.
        /// </summary>
        public NDarray<T> full_like<T>(T[] a, ValueType fill_value, Dtype? dtype = null, string order = null, bool? subok = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
                fill_value,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            if (subok!=null) kwargs["subok"]=ToPython(subok);
            dynamic py = self.InvokeMethod("full_like", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /// <summary>
        /// Create an array.
        /// 
        /// Notes
        /// 
        /// When order is ‘A’ and object is an array in neither ‘C’ nor ‘F’ order,
        /// and a copy is forced by a change in dtype, then the order of the result is
        /// not necessarily ‘C’ as expected. This is likely a bug.
        /// </summary>
        public NDarray array(NDarray @object, Dtype? dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                @object,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (copy!=null) kwargs["copy"]=ToPython(copy);
            if (order!=null) kwargs["order"]=ToPython(order);
            if (subok!=null) kwargs["subok"]=ToPython(subok);
            if (ndmin!=null) kwargs["ndmin"]=ToPython(ndmin);
            dynamic py = self.InvokeMethod("array", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Create an array.
        /// 
        /// Notes
        /// 
        /// When order is ‘A’ and object is an array in neither ‘C’ nor ‘F’ order,
        /// and a copy is forced by a change in dtype, then the order of the result is
        /// not necessarily ‘C’ as expected. This is likely a bug.
        /// </summary>
        public NDarray<T> array<T>(T[] @object, Dtype? dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                @object,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (copy!=null) kwargs["copy"]=ToPython(copy);
            if (order!=null) kwargs["order"]=ToPython(order);
            if (subok!=null) kwargs["subok"]=ToPython(subok);
            if (ndmin!=null) kwargs["ndmin"]=ToPython(ndmin);
            dynamic py = self.InvokeMethod("array", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /// <summary>
        /// Convert the input to an array.
        /// </summary>
        public NDarray asarray(NDarray a, Dtype? dtype = null, string order = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = self.InvokeMethod("asarray", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Convert the input to an array.
        /// </summary>
        public NDarray<T> asarray<T>(T[] a, Dtype? dtype = null, string order = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = self.InvokeMethod("asarray", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /// <summary>
        /// Convert the input to an ndarray, but pass ndarray subclasses through.
        /// </summary>
        public NDarray asanyarray(NDarray a, Dtype? dtype = null, string order = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = self.InvokeMethod("asanyarray", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Convert the input to an ndarray, but pass ndarray subclasses through.
        /// </summary>
        public NDarray<T> asanyarray<T>(T[] a, Dtype? dtype = null, string order = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = self.InvokeMethod("asanyarray", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /// <summary>
        /// Return a contiguous array (ndim &gt;= 1) in memory (C order).
        /// </summary>
        public NDarray ascontiguousarray(NDarray a, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("ascontiguousarray", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return a contiguous array (ndim &gt;= 1) in memory (C order).
        /// </summary>
        public NDarray<T> ascontiguousarray<T>(T[] a, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("ascontiguousarray", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /// <summary>
        /// Interpret the input as a matrix.
        /// 
        /// Unlike matrix, asmatrix does not make a copy if the input is already
        /// a matrix or an ndarray.  Equivalent to matrix(data, copy=False).
        /// </summary>
        public matrix asmatrix(NDarray data, Dtype dtype)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                data,
                dtype,
            });
            var kwargs=new PyDict();
            dynamic py = self.InvokeMethod("asmatrix", args, kwargs);
            return ToCsharp<matrix>(py);
        }
        
        /// <summary>
        /// Interpret the input as a matrix.
        /// 
        /// Unlike matrix, asmatrix does not make a copy if the input is already
        /// a matrix or an ndarray.  Equivalent to matrix(data, copy=False).
        /// </summary>
        public matrix asmatrix<T>(T[] data, Dtype dtype)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                data,
                dtype,
            });
            var kwargs=new PyDict();
            dynamic py = self.InvokeMethod("asmatrix", args, kwargs);
            return ToCsharp<matrix>(py);
        }
        
        /// <summary>
        /// Return an array copy of the given object.
        /// 
        /// Notes
        /// 
        /// This is equivalent to:
        /// </summary>
        public NDarray copy(NDarray a, string order = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = self.InvokeMethod("copy", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return an array copy of the given object.
        /// 
        /// Notes
        /// 
        /// This is equivalent to:
        /// </summary>
        public NDarray<T> copy<T>(T[] a, string order = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = self.InvokeMethod("copy", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /*
        /// <summary>
        /// Interpret a buffer as a 1-dimensional array.
        /// 
        /// Notes
        /// 
        /// If the buffer has data that is not in machine byte-order, this should
        /// be specified as part of the data-type, e.g.:
        /// 
        /// The data of the resulting array will not be byteswapped, but will be
        /// interpreted correctly.
        /// </summary>
        public void frombuffer(buffer_like buffer, Dtype? dtype = null, int? count = null, int? offset = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                buffer,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (count!=null) kwargs["count"]=ToPython(count);
            if (offset!=null) kwargs["offset"]=ToPython(offset);
            dynamic py = self.InvokeMethod("frombuffer", args, kwargs);
        }
        */
        
        /// <summary>
        /// Construct an array from data in a text or binary file.
        /// 
        /// A highly efficient way of reading binary data with a known data-type,
        /// as well as parsing simply formatted text files.  Data written using the
        /// tofile method can be read using this function.
        /// 
        /// Notes
        /// 
        /// Do not rely on the combination of tofile and fromfile for
        /// data storage, as the binary files generated are are not platform
        /// independent.  In particular, no byte-order or data-type information is
        /// saved.  Data can be stored in the platform independent .npy format
        /// using save and load instead.
        /// </summary>
        public void fromfile(string file, Dtype dtype, int count, string sep)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                file,
                dtype,
                count,
                sep,
            });
            var kwargs=new PyDict();
            dynamic py = self.InvokeMethod("fromfile", args, kwargs);
        }
        
        /// <summary>
        /// Construct an array by executing a function over each coordinate.
        /// 
        /// The resulting array therefore has a value fn(x, y, z) at
        /// coordinate (x, y, z).
        /// 
        /// Notes
        /// 
        /// Keywords other than dtype are passed to function.
        /// </summary>
        public object fromfunction(Delegate function, NumSharp.Shape shape, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                function,
                shape,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("fromfunction", args, kwargs);
            return ToCsharp<object>(py);
        }
        
        /// <summary>
        /// Create a new 1-dimensional array from an iterable object.
        /// 
        /// Notes
        /// 
        /// Specify count to improve performance.  It allows fromiter to
        /// pre-allocate the output array, instead of resizing it on demand.
        /// </summary>
        public NDarray<T> fromiter<T>(IEnumerable<T> iterable, Dtype dtype, int? count = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                iterable,
                dtype,
            });
            var kwargs=new PyDict();
            if (count!=null) kwargs["count"]=ToPython(count);
            dynamic py = self.InvokeMethod("fromiter", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /// <summary>
        /// A new 1-D array initialized from text data in a string.
        /// </summary>
        public NDarray fromstring(string @string, Dtype? dtype = null, int? count = null, string sep = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                @string,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (count!=null) kwargs["count"]=ToPython(count);
            if (sep!=null) kwargs["sep"]=ToPython(sep);
            dynamic py = self.InvokeMethod("fromstring", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Load data from a text file.
        /// 
        /// Each row in the text file must have the same number of values.
        /// 
        /// Notes
        /// 
        /// This function aims to be a fast reader for simply formatted files.  The
        /// genfromtxt function provides more sophisticated handling of, e.g.,
        /// lines with missing values.
        /// 
        /// The strings produced by the Python float.hex method can be used as
        /// input for floats.
        /// </summary>
        public NDarray loadtxt(string fname, Dtype? dtype = null, string[] comments = null, string delimiter = null, Hashtable converters = null, int? skiprows = null, int[] usecols = null, bool? unpack = null, int? ndmin = null, string encoding = null, int? max_rows = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                fname,
            });
            var kwargs=new PyDict();
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (comments!=null) kwargs["comments"]=ToPython(comments);
            if (delimiter!=null) kwargs["delimiter"]=ToPython(delimiter);
            if (converters!=null) kwargs["converters"]=ToPython(converters);
            if (skiprows!=null) kwargs["skiprows"]=ToPython(skiprows);
            if (usecols!=null) kwargs["usecols"]=ToPython(usecols);
            if (unpack!=null) kwargs["unpack"]=ToPython(unpack);
            if (ndmin!=null) kwargs["ndmin"]=ToPython(ndmin);
            if (encoding!=null) kwargs["encoding"]=ToPython(encoding);
            if (max_rows!=null) kwargs["max_rows"]=ToPython(max_rows);
            dynamic py = self.InvokeMethod("loadtxt", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Create a chararray.
        /// 
        /// Versus a regular NumPy array of type str or unicode, this
        /// class adds the following functionality:
        /// </summary>
        public void array(string[] obj, int? itemsize = null, bool? copy = null, bool? unicode = null, string order = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                obj,
            });
            var kwargs=new PyDict();
            if (itemsize!=null) kwargs["itemsize"]=ToPython(itemsize);
            if (copy!=null) kwargs["copy"]=ToPython(copy);
            if (unicode!=null) kwargs["unicode"]=ToPython(unicode);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = self.InvokeMethod("array", args, kwargs);
        }
        
        /// <summary>
        /// Convert the input to a chararray, copying the data only if
        /// necessary.
        /// 
        /// Versus a regular NumPy array of type str or unicode, this
        /// class adds the following functionality:
        /// </summary>
        public void asarray(string[] obj, int? itemsize = null, bool? unicode = null, string order = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                obj,
            });
            var kwargs=new PyDict();
            if (itemsize!=null) kwargs["itemsize"]=ToPython(itemsize);
            if (unicode!=null) kwargs["unicode"]=ToPython(unicode);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = self.InvokeMethod("asarray", args, kwargs);
        }
        
        /// <summary>
        /// Return evenly spaced values within a given interval.
        /// 
        /// Values are generated within the half-open interval [start, stop)
        /// (in other words, the interval including start but excluding stop).
        /// For integer arguments the function is equivalent to the Python built-in
        /// range function, but returns an ndarray rather than a list.
        /// 
        /// When using a non-integer step, such as 0.1, the results will often not
        /// be consistent.  It is better to use numpy.linspace for these cases.
        /// </summary>
        public NDarray arange(byte start, byte stop, byte step = 1, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                start,
                stop,
            });
            var kwargs=new PyDict();
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return evenly spaced values within a given interval.
        /// 
        /// Values are generated within the half-open interval [start, stop)
        /// (in other words, the interval including start but excluding stop).
        /// For integer arguments the function is equivalent to the Python built-in
        /// range function, but returns an ndarray rather than a list.
        /// 
        /// When using a non-integer step, such as 0.1, the results will often not
        /// be consistent.  It is better to use numpy.linspace for these cases.
        /// </summary>
        public NDarray arange(byte stop, byte step = 1, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                stop,
            });
            var kwargs=new PyDict();
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return evenly spaced values within a given interval.
        /// 
        /// Values are generated within the half-open interval [start, stop)
        /// (in other words, the interval including start but excluding stop).
        /// For integer arguments the function is equivalent to the Python built-in
        /// range function, but returns an ndarray rather than a list.
        /// 
        /// When using a non-integer step, such as 0.1, the results will often not
        /// be consistent.  It is better to use numpy.linspace for these cases.
        /// </summary>
        public NDarray arange(short start, short stop, short step = 1, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                start,
                stop,
            });
            var kwargs=new PyDict();
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return evenly spaced values within a given interval.
        /// 
        /// Values are generated within the half-open interval [start, stop)
        /// (in other words, the interval including start but excluding stop).
        /// For integer arguments the function is equivalent to the Python built-in
        /// range function, but returns an ndarray rather than a list.
        /// 
        /// When using a non-integer step, such as 0.1, the results will often not
        /// be consistent.  It is better to use numpy.linspace for these cases.
        /// </summary>
        public NDarray arange(short stop, short step = 1, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                stop,
            });
            var kwargs=new PyDict();
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return evenly spaced values within a given interval.
        /// 
        /// Values are generated within the half-open interval [start, stop)
        /// (in other words, the interval including start but excluding stop).
        /// For integer arguments the function is equivalent to the Python built-in
        /// range function, but returns an ndarray rather than a list.
        /// 
        /// When using a non-integer step, such as 0.1, the results will often not
        /// be consistent.  It is better to use numpy.linspace for these cases.
        /// </summary>
        public NDarray arange(int start, int stop, int step = 1, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                start,
                stop,
            });
            var kwargs=new PyDict();
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return evenly spaced values within a given interval.
        /// 
        /// Values are generated within the half-open interval [start, stop)
        /// (in other words, the interval including start but excluding stop).
        /// For integer arguments the function is equivalent to the Python built-in
        /// range function, but returns an ndarray rather than a list.
        /// 
        /// When using a non-integer step, such as 0.1, the results will often not
        /// be consistent.  It is better to use numpy.linspace for these cases.
        /// </summary>
        public NDarray arange(int stop, int step = 1, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                stop,
            });
            var kwargs=new PyDict();
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return evenly spaced values within a given interval.
        /// 
        /// Values are generated within the half-open interval [start, stop)
        /// (in other words, the interval including start but excluding stop).
        /// For integer arguments the function is equivalent to the Python built-in
        /// range function, but returns an ndarray rather than a list.
        /// 
        /// When using a non-integer step, such as 0.1, the results will often not
        /// be consistent.  It is better to use numpy.linspace for these cases.
        /// </summary>
        public NDarray arange(long start, long stop, long step = 1, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                start,
                stop,
            });
            var kwargs=new PyDict();
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return evenly spaced values within a given interval.
        /// 
        /// Values are generated within the half-open interval [start, stop)
        /// (in other words, the interval including start but excluding stop).
        /// For integer arguments the function is equivalent to the Python built-in
        /// range function, but returns an ndarray rather than a list.
        /// 
        /// When using a non-integer step, such as 0.1, the results will often not
        /// be consistent.  It is better to use numpy.linspace for these cases.
        /// </summary>
        public NDarray arange(long stop, long step = 1, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                stop,
            });
            var kwargs=new PyDict();
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return evenly spaced values within a given interval.
        /// 
        /// Values are generated within the half-open interval [start, stop)
        /// (in other words, the interval including start but excluding stop).
        /// For integer arguments the function is equivalent to the Python built-in
        /// range function, but returns an ndarray rather than a list.
        /// 
        /// When using a non-integer step, such as 0.1, the results will often not
        /// be consistent.  It is better to use numpy.linspace for these cases.
        /// </summary>
        public NDarray arange(float start, float stop, float step = 1, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                start,
                stop,
            });
            var kwargs=new PyDict();
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return evenly spaced values within a given interval.
        /// 
        /// Values are generated within the half-open interval [start, stop)
        /// (in other words, the interval including start but excluding stop).
        /// For integer arguments the function is equivalent to the Python built-in
        /// range function, but returns an ndarray rather than a list.
        /// 
        /// When using a non-integer step, such as 0.1, the results will often not
        /// be consistent.  It is better to use numpy.linspace for these cases.
        /// </summary>
        public NDarray arange(float stop, float step = 1, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                stop,
            });
            var kwargs=new PyDict();
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return evenly spaced values within a given interval.
        /// 
        /// Values are generated within the half-open interval [start, stop)
        /// (in other words, the interval including start but excluding stop).
        /// For integer arguments the function is equivalent to the Python built-in
        /// range function, but returns an ndarray rather than a list.
        /// 
        /// When using a non-integer step, such as 0.1, the results will often not
        /// be consistent.  It is better to use numpy.linspace for these cases.
        /// </summary>
        public NDarray arange(double start, double stop, double step = 1, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                start,
                stop,
            });
            var kwargs=new PyDict();
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return evenly spaced values within a given interval.
        /// 
        /// Values are generated within the half-open interval [start, stop)
        /// (in other words, the interval including start but excluding stop).
        /// For integer arguments the function is equivalent to the Python built-in
        /// range function, but returns an ndarray rather than a list.
        /// 
        /// When using a non-integer step, such as 0.1, the results will often not
        /// be consistent.  It is better to use numpy.linspace for these cases.
        /// </summary>
        public NDarray arange(double stop, double step = 1, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                stop,
            });
            var kwargs=new PyDict();
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        // Error generating delaration: linspace
        // Message: Return tuple
        /*
           at CodeMinion.Core.CodeGenerator.GenerateReturnType(Declaration decl) in C:\DEV\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 228
   at CodeMinion.Core.CodeGenerator.GenerateApiFunction(Declaration decl, CodeWriter s) in C:\DEV\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 56
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass32_0.<GenerateApiImpl>b__1() in C:\DEV\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 365
        ----------------------------
        Declaration JSON:
        {
  "Name": "linspace",
  "ClassName": "numpy",
  "Arguments": [
    {
      "IsNullable": false,
      "IsValueType": false,
      "Name": "start",
      "Type": "NDarray",
      "DefaultValue": null,
      "IsNamedArg": false
    },
    {
      "IsNullable": false,
      "IsValueType": false,
      "Name": "stop",
      "Type": "NDarray",
      "DefaultValue": null,
      "IsNamedArg": false
    },
    {
      "IsNullable": true,
      "IsValueType": false,
      "Name": "num",
      "Type": "int",
      "DefaultValue": null,
      "IsNamedArg": true
    },
    {
      "IsNullable": true,
      "IsValueType": false,
      "Name": "endpoint",
      "Type": "bool",
      "DefaultValue": null,
      "IsNamedArg": true
    },
    {
      "IsNullable": true,
      "IsValueType": false,
      "Name": "retstep",
      "Type": "bool",
      "DefaultValue": null,
      "IsNamedArg": true
    },
    {
      "IsNullable": true,
      "IsValueType": true,
      "Name": "dtype",
      "Type": "Dtype",
      "DefaultValue": null,
      "IsNamedArg": true
    },
    {
      "IsNullable": true,
      "IsValueType": false,
      "Name": "axis",
      "Type": "int",
      "DefaultValue": null,
      "IsNamedArg": true
    }
  ],
  "Returns": [
    {
      "IsNullable": false,
      "IsValueType": false,
      "Name": null,
      "Type": "NDarray",
      "DefaultValue": null,
      "IsNamedArg": false
    },
    {
      "IsNullable": false,
      "IsValueType": false,
      "Name": null,
      "Type": "float",
      "DefaultValue": null,
      "IsNamedArg": false
    }
  ],
  "IsDeprecated": false,
  "ManualOverride": false,
  "Generics": null,
  "CommentOut": false,
  "DebuggerBreak": false,
  "Description": "Return evenly spaced numbers over a specified interval.\r\n\r\nReturns num evenly spaced samples, calculated over the\ninterval [start, stop].\r\n\r\nThe endpoint of the interval can optionally be excluded."
}
        */
        // Error generating delaration: linspace
        // Message: Return tuple
        /*
           at CodeMinion.Core.CodeGenerator.GenerateReturnType(Declaration decl) in C:\DEV\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 228
   at CodeMinion.Core.CodeGenerator.GenerateApiFunction(Declaration decl, CodeWriter s) in C:\DEV\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 56
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass32_0.<GenerateApiImpl>b__1() in C:\DEV\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 365
        ----------------------------
        Declaration JSON:
        {
  "Name": "linspace",
  "ClassName": "numpy",
  "Arguments": [
    {
      "IsNullable": false,
      "IsValueType": false,
      "Name": "start",
      "Type": "T[]",
      "DefaultValue": null,
      "IsNamedArg": false
    },
    {
      "IsNullable": false,
      "IsValueType": false,
      "Name": "stop",
      "Type": "T[]",
      "DefaultValue": null,
      "IsNamedArg": false
    },
    {
      "IsNullable": true,
      "IsValueType": false,
      "Name": "num",
      "Type": "int",
      "DefaultValue": null,
      "IsNamedArg": true
    },
    {
      "IsNullable": true,
      "IsValueType": false,
      "Name": "endpoint",
      "Type": "bool",
      "DefaultValue": null,
      "IsNamedArg": true
    },
    {
      "IsNullable": true,
      "IsValueType": false,
      "Name": "retstep",
      "Type": "bool",
      "DefaultValue": null,
      "IsNamedArg": true
    },
    {
      "IsNullable": true,
      "IsValueType": true,
      "Name": "dtype",
      "Type": "Dtype",
      "DefaultValue": null,
      "IsNamedArg": true
    },
    {
      "IsNullable": true,
      "IsValueType": false,
      "Name": "axis",
      "Type": "int",
      "DefaultValue": null,
      "IsNamedArg": true
    }
  ],
  "Returns": [
    {
      "IsNullable": false,
      "IsValueType": false,
      "Name": null,
      "Type": "NDarray<T>",
      "DefaultValue": null,
      "IsNamedArg": false
    },
    {
      "IsNullable": false,
      "IsValueType": false,
      "Name": null,
      "Type": "float",
      "DefaultValue": null,
      "IsNamedArg": false
    }
  ],
  "IsDeprecated": false,
  "ManualOverride": false,
  "Generics": [
    "T"
  ],
  "CommentOut": false,
  "DebuggerBreak": false,
  "Description": "Return evenly spaced numbers over a specified interval.\r\n\r\nReturns num evenly spaced samples, calculated over the\ninterval [start, stop].\r\n\r\nThe endpoint of the interval can optionally be excluded."
}
        */
        /// <summary>
        /// Return numbers spaced evenly on a log scale.
        /// 
        /// In linear space, the sequence starts at base ** start
        /// (base to the power of start) and ends with base ** stop
        /// (see endpoint below).
        /// 
        /// Notes
        /// 
        /// Logspace is equivalent to the code
        /// </summary>
        public NDarray logspace(NDarray start, NDarray stop, int? num = null, bool? endpoint = null, float? @base = null, Dtype? dtype = null, int? axis = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                start,
                stop,
            });
            var kwargs=new PyDict();
            if (num!=null) kwargs["num"]=ToPython(num);
            if (endpoint!=null) kwargs["endpoint"]=ToPython(endpoint);
            if (@base!=null) kwargs["base"]=ToPython(@base);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            dynamic py = self.InvokeMethod("logspace", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return numbers spaced evenly on a log scale.
        /// 
        /// In linear space, the sequence starts at base ** start
        /// (base to the power of start) and ends with base ** stop
        /// (see endpoint below).
        /// 
        /// Notes
        /// 
        /// Logspace is equivalent to the code
        /// </summary>
        public NDarray<T> logspace<T>(T[] start, T[] stop, int? num = null, bool? endpoint = null, float? @base = null, Dtype? dtype = null, int? axis = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                start,
                stop,
            });
            var kwargs=new PyDict();
            if (num!=null) kwargs["num"]=ToPython(num);
            if (endpoint!=null) kwargs["endpoint"]=ToPython(endpoint);
            if (@base!=null) kwargs["base"]=ToPython(@base);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            dynamic py = self.InvokeMethod("logspace", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /// <summary>
        /// Return numbers spaced evenly on a log scale (a geometric progression).
        /// 
        /// This is similar to logspace, but with endpoints specified directly.
        /// Each output sample is a constant multiple of the previous.
        /// 
        /// Notes
        /// 
        /// If the inputs or dtype are complex, the output will follow a logarithmic
        /// spiral in the complex plane.  (There are an infinite number of spirals
        /// passing through two points; the output will follow the shortest such path.)
        /// </summary>
        public NDarray geomspace(NDarray start, NDarray stop, int? num = null, bool? endpoint = null, Dtype? dtype = null, int? axis = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                start,
                stop,
            });
            var kwargs=new PyDict();
            if (num!=null) kwargs["num"]=ToPython(num);
            if (endpoint!=null) kwargs["endpoint"]=ToPython(endpoint);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            dynamic py = self.InvokeMethod("geomspace", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return numbers spaced evenly on a log scale (a geometric progression).
        /// 
        /// This is similar to logspace, but with endpoints specified directly.
        /// Each output sample is a constant multiple of the previous.
        /// 
        /// Notes
        /// 
        /// If the inputs or dtype are complex, the output will follow a logarithmic
        /// spiral in the complex plane.  (There are an infinite number of spirals
        /// passing through two points; the output will follow the shortest such path.)
        /// </summary>
        public NDarray<T> geomspace<T>(T[] start, T[] stop, int? num = null, bool? endpoint = null, Dtype? dtype = null, int? axis = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                start,
                stop,
            });
            var kwargs=new PyDict();
            if (num!=null) kwargs["num"]=ToPython(num);
            if (endpoint!=null) kwargs["endpoint"]=ToPython(endpoint);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            dynamic py = self.InvokeMethod("geomspace", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /*
        /// <summary>
        /// Return coordinate matrices from coordinate vectors.
        /// 
        /// Make N-D coordinate arrays for vectorized evaluations of
        /// N-D scalar/vector fields over N-D grids, given
        /// one-dimensional coordinate arrays x1, x2,…, xn.
        /// 
        /// Notes
        /// 
        /// This function supports both indexing conventions through the indexing
        /// keyword argument.  Giving the string ‘ij’ returns a meshgrid with
        /// matrix indexing, while ‘xy’ returns a meshgrid with Cartesian indexing.
        /// In the 2-D case with inputs of length M and N, the outputs are of shape
        /// (N, M) for ‘xy’ indexing and (M, N) for ‘ij’ indexing.  In the 3-D case
        /// with inputs of length M, N and P, outputs are of shape (N, M, P) for
        /// ‘xy’ indexing and (M, N, P) for ‘ij’ indexing.  The difference is
        /// illustrated by the following code snippet:
        /// 
        /// In the 1-D and 0-D case, the indexing and sparse keywords have no effect.
        /// </summary>
        public NDarray meshgrid(NDarray x1, x2,…, xn, {‘xy’ indexing = null, bool? sparse = null, bool? copy = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                x1, x2,…, xn,
            });
            var kwargs=new PyDict();
            if (indexing!=null) kwargs["indexing"]=ToPython(indexing);
            if (sparse!=null) kwargs["sparse"]=ToPython(sparse);
            if (copy!=null) kwargs["copy"]=ToPython(copy);
            dynamic py = self.InvokeMethod("meshgrid", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        */
        
        /*
        /// <summary>
        /// Return coordinate matrices from coordinate vectors.
        /// 
        /// Make N-D coordinate arrays for vectorized evaluations of
        /// N-D scalar/vector fields over N-D grids, given
        /// one-dimensional coordinate arrays x1, x2,…, xn.
        /// 
        /// Notes
        /// 
        /// This function supports both indexing conventions through the indexing
        /// keyword argument.  Giving the string ‘ij’ returns a meshgrid with
        /// matrix indexing, while ‘xy’ returns a meshgrid with Cartesian indexing.
        /// In the 2-D case with inputs of length M and N, the outputs are of shape
        /// (N, M) for ‘xy’ indexing and (M, N) for ‘ij’ indexing.  In the 3-D case
        /// with inputs of length M, N and P, outputs are of shape (N, M, P) for
        /// ‘xy’ indexing and (M, N, P) for ‘ij’ indexing.  The difference is
        /// illustrated by the following code snippet:
        /// 
        /// In the 1-D and 0-D case, the indexing and sparse keywords have no effect.
        /// </summary>
        public NDarray<T> meshgrid<T>(T[] x1, x2,…, xn, {‘xy’ indexing = null, bool? sparse = null, bool? copy = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                x1, x2,…, xn,
            });
            var kwargs=new PyDict();
            if (indexing!=null) kwargs["indexing"]=ToPython(indexing);
            if (sparse!=null) kwargs["sparse"]=ToPython(sparse);
            if (copy!=null) kwargs["copy"]=ToPython(copy);
            dynamic py = self.InvokeMethod("meshgrid", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        */
        
        /// <summary>
        /// Extract a diagonal or construct a diagonal array.
        /// 
        /// See the more detailed documentation for numpy.diagonal if you use this
        /// function to extract a diagonal and wish to write to the resulting array;
        /// whether it returns a copy or a view depends on what version of numpy you
        /// are using.
        /// </summary>
        public NDarray diag(NDarray v, int? k = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                v,
            });
            var kwargs=new PyDict();
            if (k!=null) kwargs["k"]=ToPython(k);
            dynamic py = self.InvokeMethod("diag", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Extract a diagonal or construct a diagonal array.
        /// 
        /// See the more detailed documentation for numpy.diagonal if you use this
        /// function to extract a diagonal and wish to write to the resulting array;
        /// whether it returns a copy or a view depends on what version of numpy you
        /// are using.
        /// </summary>
        public NDarray<T> diag<T>(T[] v, int? k = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                v,
            });
            var kwargs=new PyDict();
            if (k!=null) kwargs["k"]=ToPython(k);
            dynamic py = self.InvokeMethod("diag", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /// <summary>
        /// Create a two-dimensional array with the flattened input as a diagonal.
        /// </summary>
        public NDarray diagflat(NDarray v, int? k = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                v,
            });
            var kwargs=new PyDict();
            if (k!=null) kwargs["k"]=ToPython(k);
            dynamic py = self.InvokeMethod("diagflat", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Create a two-dimensional array with the flattened input as a diagonal.
        /// </summary>
        public NDarray<T> diagflat<T>(T[] v, int? k = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                v,
            });
            var kwargs=new PyDict();
            if (k!=null) kwargs["k"]=ToPython(k);
            dynamic py = self.InvokeMethod("diagflat", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /// <summary>
        /// An array with ones at and below the given diagonal and zeros elsewhere.
        /// </summary>
        public NDarray tri(int N, int? M = null, int? k = null, Dtype? dtype = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                N,
            });
            var kwargs=new PyDict();
            if (M!=null) kwargs["M"]=ToPython(M);
            if (k!=null) kwargs["k"]=ToPython(k);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("tri", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Lower triangle of an array.
        /// 
        /// Return a copy of an array with elements above the k-th diagonal zeroed.
        /// </summary>
        public NDarray tril(NDarray m, int? k = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                m,
            });
            var kwargs=new PyDict();
            if (k!=null) kwargs["k"]=ToPython(k);
            dynamic py = self.InvokeMethod("tril", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Lower triangle of an array.
        /// 
        /// Return a copy of an array with elements above the k-th diagonal zeroed.
        /// </summary>
        public NDarray<T> tril<T>(T[] m, int? k = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                m,
            });
            var kwargs=new PyDict();
            if (k!=null) kwargs["k"]=ToPython(k);
            dynamic py = self.InvokeMethod("tril", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /// <summary>
        /// Generate a Vandermonde matrix.
        /// 
        /// The columns of the output matrix are powers of the input vector. The
        /// order of the powers is determined by the increasing boolean argument.
        /// Specifically, when increasing is False, the i-th output column is
        /// the input vector raised element-wise to the power of N - i - 1. Such
        /// a matrix with a geometric progression in each row is named for Alexandre-
        /// Theophile Vandermonde.
        /// </summary>
        public NDarray vander(NDarray x, int? N = null, bool? increasing = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                x,
            });
            var kwargs=new PyDict();
            if (N!=null) kwargs["N"]=ToPython(N);
            if (increasing!=null) kwargs["increasing"]=ToPython(increasing);
            dynamic py = self.InvokeMethod("vander", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Generate a Vandermonde matrix.
        /// 
        /// The columns of the output matrix are powers of the input vector. The
        /// order of the powers is determined by the increasing boolean argument.
        /// Specifically, when increasing is False, the i-th output column is
        /// the input vector raised element-wise to the power of N - i - 1. Such
        /// a matrix with a geometric progression in each row is named for Alexandre-
        /// Theophile Vandermonde.
        /// </summary>
        public NDarray<T> vander<T>(T[] x, int? N = null, bool? increasing = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                x,
            });
            var kwargs=new PyDict();
            if (N!=null) kwargs["N"]=ToPython(N);
            if (increasing!=null) kwargs["increasing"]=ToPython(increasing);
            dynamic py = self.InvokeMethod("vander", args, kwargs);
            return ToCsharp<NDarray<T>>(py);
        }
        
        /*
        /// <summary>
        /// Interpret the input as a matrix.
        /// 
        /// Unlike matrix, asmatrix does not make a copy if the input is already
        /// a matrix or an ndarray.  Equivalent to matrix(data, copy=False).
        /// </summary>
        public matrix mat(NDarray data, Dtype dtype)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                data,
                dtype,
            });
            var kwargs=new PyDict();
            dynamic py = self.InvokeMethod("mat", args, kwargs);
            return ToCsharp<matrix>(py);
        }
        */
        
        /*
        /// <summary>
        /// Interpret the input as a matrix.
        /// 
        /// Unlike matrix, asmatrix does not make a copy if the input is already
        /// a matrix or an ndarray.  Equivalent to matrix(data, copy=False).
        /// </summary>
        public matrix mat<T>(T[] data, Dtype dtype)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                data,
                dtype,
            });
            var kwargs=new PyDict();
            dynamic py = self.InvokeMethod("mat", args, kwargs);
            return ToCsharp<matrix>(py);
        }
        */
        
        /*
        /// <summary>
        /// Build a matrix object from a string, nested sequence, or array.
        /// </summary>
        public matrix bmat(string obj, Hashtable ldict = null, Hashtable gdict = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                obj,
            });
            var kwargs=new PyDict();
            if (ldict!=null) kwargs["ldict"]=ToPython(ldict);
            if (gdict!=null) kwargs["gdict"]=ToPython(gdict);
            dynamic py = self.InvokeMethod("bmat", args, kwargs);
            return ToCsharp<matrix>(py);
        }
        */
        
        /*
        /// <summary>
        /// Build a matrix object from a string, nested sequence, or array.
        /// </summary>
        public matrix<T> bmat<T>(T[] obj, Hashtable ldict = null, Hashtable gdict = null)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                obj,
            });
            var kwargs=new PyDict();
            if (ldict!=null) kwargs["ldict"]=ToPython(ldict);
            if (gdict!=null) kwargs["gdict"]=ToPython(gdict);
            dynamic py = self.InvokeMethod("bmat", args, kwargs);
            return ToCsharp<matrix<T>>(py);
        }
        */
        
    }
}
