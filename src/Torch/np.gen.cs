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
    public static partial class np
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
        public static NDarray empty(NumSharp.Shape shape, Dtype? dtype = null, string order = null)
            => NumPy.Instance.empty(shape, dtype:dtype, order:order);
        
        /// <summary>
        /// Return a new array with the same shape and type as a given array.
        /// 
        /// Notes
        /// 
        /// This function does not initialize the returned array; to do that use
        /// zeros_like or ones_like instead.  It may be marginally faster than
        /// the functions that do set the array values.
        /// </summary>
        public static NDarray empty_like(NDarray prototype, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.empty_like(prototype, dtype:dtype, order:order, subok:subok);
        
        /// <summary>
        /// Return a new array with the same shape and type as a given array.
        /// 
        /// Notes
        /// 
        /// This function does not initialize the returned array; to do that use
        /// zeros_like or ones_like instead.  It may be marginally faster than
        /// the functions that do set the array values.
        /// </summary>
        public static NDarray<T> empty_like<T>(T[] prototype, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.empty_like(prototype, dtype:dtype, order:order, subok:subok);
        
        /// <summary>
        /// Return a 2-D array with ones on the diagonal and zeros elsewhere.
        /// </summary>
        public static NDarray eye(int N, int? M = null, int? k = null, Dtype? dtype = null, string order = null)
            => NumPy.Instance.eye(N, M:M, k:k, dtype:dtype, order:order);
        
        /// <summary>
        /// Return the identity array.
        /// 
        /// The identity array is a square array with ones on
        /// the main diagonal.
        /// </summary>
        public static NDarray identity(int n, Dtype? dtype = null)
            => NumPy.Instance.identity(n, dtype:dtype);
        
        /// <summary>
        /// Return a new array of given shape and type, filled with ones.
        /// </summary>
        public static NDarray ones(NumSharp.Shape shape, Dtype? dtype = null, string order = null)
            => NumPy.Instance.ones(shape, dtype:dtype, order:order);
        
        /// <summary>
        /// Return an array of ones with the same shape and type as a given array.
        /// </summary>
        public static NDarray ones_like(NDarray a, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.ones_like(a, dtype:dtype, order:order, subok:subok);
        
        /// <summary>
        /// Return an array of ones with the same shape and type as a given array.
        /// </summary>
        public static NDarray<T> ones_like<T>(T[] a, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.ones_like(a, dtype:dtype, order:order, subok:subok);
        
        /// <summary>
        /// Return a new array of given shape and type, filled with zeros.
        /// </summary>
        public static NDarray zeros(NumSharp.Shape shape, Dtype? dtype = null, string order = null)
            => NumPy.Instance.zeros(shape, dtype:dtype, order:order);
        
        /// <summary>
        /// Return an array of zeros with the same shape and type as a given array.
        /// </summary>
        public static NDarray zeros_like(NDarray a, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.zeros_like(a, dtype:dtype, order:order, subok:subok);
        
        /// <summary>
        /// Return an array of zeros with the same shape and type as a given array.
        /// </summary>
        public static NDarray<T> zeros_like<T>(T[] a, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.zeros_like(a, dtype:dtype, order:order, subok:subok);
        
        /// <summary>
        /// Return a new array of given shape and type, filled with fill_value.
        /// </summary>
        public static NDarray full(NumSharp.Shape shape, ValueType fill_value, Dtype? dtype = null, string order = null)
            => NumPy.Instance.full(shape, fill_value, dtype:dtype, order:order);
        
        /// <summary>
        /// Return a full array with the same shape and type as a given array.
        /// </summary>
        public static NDarray full_like(NDarray a, ValueType fill_value, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.full_like(a, fill_value, dtype:dtype, order:order, subok:subok);
        
        /// <summary>
        /// Return a full array with the same shape and type as a given array.
        /// </summary>
        public static NDarray<T> full_like<T>(T[] a, ValueType fill_value, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.full_like(a, fill_value, dtype:dtype, order:order, subok:subok);
        
        /// <summary>
        /// Create an array.
        /// 
        /// Notes
        /// 
        /// When order is ‘A’ and object is an array in neither ‘C’ nor ‘F’ order,
        /// and a copy is forced by a change in dtype, then the order of the result is
        /// not necessarily ‘C’ as expected. This is likely a bug.
        /// </summary>
        public static NDarray array(NDarray @object, Dtype? dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
            => NumPy.Instance.array(@object, dtype:dtype, copy:copy, order:order, subok:subok, ndmin:ndmin);
        
        /// <summary>
        /// Create an array.
        /// 
        /// Notes
        /// 
        /// When order is ‘A’ and object is an array in neither ‘C’ nor ‘F’ order,
        /// and a copy is forced by a change in dtype, then the order of the result is
        /// not necessarily ‘C’ as expected. This is likely a bug.
        /// </summary>
        public static NDarray<T> array<T>(T[] @object, Dtype? dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
            => NumPy.Instance.array(@object, dtype:dtype, copy:copy, order:order, subok:subok, ndmin:ndmin);
        
        /// <summary>
        /// Convert the input to an array.
        /// </summary>
        public static NDarray asarray(NDarray a, Dtype? dtype = null, string order = null)
            => NumPy.Instance.asarray(a, dtype:dtype, order:order);
        
        /// <summary>
        /// Convert the input to an array.
        /// </summary>
        public static NDarray<T> asarray<T>(T[] a, Dtype? dtype = null, string order = null)
            => NumPy.Instance.asarray(a, dtype:dtype, order:order);
        
        /// <summary>
        /// Convert the input to an ndarray, but pass ndarray subclasses through.
        /// </summary>
        public static NDarray asanyarray(NDarray a, Dtype? dtype = null, string order = null)
            => NumPy.Instance.asanyarray(a, dtype:dtype, order:order);
        
        /// <summary>
        /// Convert the input to an ndarray, but pass ndarray subclasses through.
        /// </summary>
        public static NDarray<T> asanyarray<T>(T[] a, Dtype? dtype = null, string order = null)
            => NumPy.Instance.asanyarray(a, dtype:dtype, order:order);
        
        /// <summary>
        /// Return a contiguous array (ndim &gt;= 1) in memory (C order).
        /// </summary>
        public static NDarray ascontiguousarray(NDarray a, Dtype? dtype = null)
            => NumPy.Instance.ascontiguousarray(a, dtype:dtype);
        
        /// <summary>
        /// Return a contiguous array (ndim &gt;= 1) in memory (C order).
        /// </summary>
        public static NDarray<T> ascontiguousarray<T>(T[] a, Dtype? dtype = null)
            => NumPy.Instance.ascontiguousarray(a, dtype:dtype);
        
        /// <summary>
        /// Interpret the input as a matrix.
        /// 
        /// Unlike matrix, asmatrix does not make a copy if the input is already
        /// a matrix or an ndarray.  Equivalent to matrix(data, copy=False).
        /// </summary>
        public static matrix asmatrix(NDarray data, Dtype dtype)
            => NumPy.Instance.asmatrix(data, dtype);
        
        /// <summary>
        /// Interpret the input as a matrix.
        /// 
        /// Unlike matrix, asmatrix does not make a copy if the input is already
        /// a matrix or an ndarray.  Equivalent to matrix(data, copy=False).
        /// </summary>
        public static matrix asmatrix<T>(T[] data, Dtype dtype)
            => NumPy.Instance.asmatrix(data, dtype);
        
        /// <summary>
        /// Return an array copy of the given object.
        /// 
        /// Notes
        /// 
        /// This is equivalent to:
        /// </summary>
        public static NDarray copy(NDarray a, string order = null)
            => NumPy.Instance.copy(a, order:order);
        
        /// <summary>
        /// Return an array copy of the given object.
        /// 
        /// Notes
        /// 
        /// This is equivalent to:
        /// </summary>
        public static NDarray<T> copy<T>(T[] a, string order = null)
            => NumPy.Instance.copy(a, order:order);
        
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
        public static void frombuffer(buffer_like buffer, Dtype? dtype = null, int? count = null, int? offset = null)
            => NumPy.Instance.frombuffer(buffer, dtype:dtype, count:count, offset:offset);
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
        public static void fromfile(string file, Dtype dtype, int count, string sep)
            => NumPy.Instance.fromfile(file, dtype, count, sep);
        
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
        public static object fromfunction(Delegate function, NumSharp.Shape shape, Dtype? dtype = null)
            => NumPy.Instance.fromfunction(function, shape, dtype:dtype);
        
        /// <summary>
        /// Create a new 1-dimensional array from an iterable object.
        /// 
        /// Notes
        /// 
        /// Specify count to improve performance.  It allows fromiter to
        /// pre-allocate the output array, instead of resizing it on demand.
        /// </summary>
        public static NDarray<T> fromiter<T>(IEnumerable<T> iterable, Dtype dtype, int? count = null)
            => NumPy.Instance.fromiter(iterable, dtype, count:count);
        
        /// <summary>
        /// A new 1-D array initialized from text data in a string.
        /// </summary>
        public static NDarray fromstring(string @string, Dtype? dtype = null, int? count = null, string sep = null)
            => NumPy.Instance.fromstring(@string, dtype:dtype, count:count, sep:sep);
        
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
        public static NDarray loadtxt(string fname, Dtype? dtype = null, string[] comments = null, string delimiter = null, Hashtable converters = null, int? skiprows = null, int[] usecols = null, bool? unpack = null, int? ndmin = null, string encoding = null, int? max_rows = null)
            => NumPy.Instance.loadtxt(fname, dtype:dtype, comments:comments, delimiter:delimiter, converters:converters, skiprows:skiprows, usecols:usecols, unpack:unpack, ndmin:ndmin, encoding:encoding, max_rows:max_rows);
        
        /// <summary>
        /// Create a chararray.
        /// 
        /// Versus a regular NumPy array of type str or unicode, this
        /// class adds the following functionality:
        /// </summary>
        public static void array(string[] obj, int? itemsize = null, bool? copy = null, bool? unicode = null, string order = null)
            => NumPy.Instance.array(obj, itemsize:itemsize, copy:copy, unicode:unicode, order:order);
        
        /// <summary>
        /// Convert the input to a chararray, copying the data only if
        /// necessary.
        /// 
        /// Versus a regular NumPy array of type str or unicode, this
        /// class adds the following functionality:
        /// </summary>
        public static void asarray(string[] obj, int? itemsize = null, bool? unicode = null, string order = null)
            => NumPy.Instance.asarray(obj, itemsize:itemsize, unicode:unicode, order:order);
        
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
        public static NDarray arange(byte start, byte stop, byte step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(start, stop, step:step, dtype:dtype);
        
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
        public static NDarray arange(byte stop, byte step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(stop, step:step, dtype:dtype);
        
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
        public static NDarray arange(short start, short stop, short step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(start, stop, step:step, dtype:dtype);
        
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
        public static NDarray arange(short stop, short step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(stop, step:step, dtype:dtype);
        
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
        public static NDarray arange(int start, int stop, int step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(start, stop, step:step, dtype:dtype);
        
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
        public static NDarray arange(int stop, int step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(stop, step:step, dtype:dtype);
        
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
        public static NDarray arange(long start, long stop, long step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(start, stop, step:step, dtype:dtype);
        
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
        public static NDarray arange(long stop, long step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(stop, step:step, dtype:dtype);
        
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
        public static NDarray arange(float start, float stop, float step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(start, stop, step:step, dtype:dtype);
        
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
        public static NDarray arange(float stop, float step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(stop, step:step, dtype:dtype);
        
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
        public static NDarray arange(double start, double stop, double step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(start, stop, step:step, dtype:dtype);
        
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
        public static NDarray arange(double stop, double step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(stop, step:step, dtype:dtype);
        
        // Error generating delaration: linspace
        // Message: Return tuple
        /*
           at CodeMinion.Core.CodeGenerator.GenerateReturnType(Declaration decl) in C:\DEV\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 228
   at CodeMinion.Core.CodeGenerator.GenerateStaticApiRedirection(StaticApi api, Declaration decl, CodeWriter s) in C:\DEV\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 84
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass30_0.<GenerateStaticApi>b__1() in C:\DEV\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 321
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
   at CodeMinion.Core.CodeGenerator.GenerateStaticApiRedirection(StaticApi api, Declaration decl, CodeWriter s) in C:\DEV\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 84
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass30_0.<GenerateStaticApi>b__1() in C:\DEV\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 321
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
        public static NDarray logspace(NDarray start, NDarray stop, int? num = null, bool? endpoint = null, float? @base = null, Dtype? dtype = null, int? axis = null)
            => NumPy.Instance.logspace(start, stop, num:num, endpoint:endpoint, @base:@base, dtype:dtype, axis:axis);
        
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
        public static NDarray<T> logspace<T>(T[] start, T[] stop, int? num = null, bool? endpoint = null, float? @base = null, Dtype? dtype = null, int? axis = null)
            => NumPy.Instance.logspace(start, stop, num:num, endpoint:endpoint, @base:@base, dtype:dtype, axis:axis);
        
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
        public static NDarray geomspace(NDarray start, NDarray stop, int? num = null, bool? endpoint = null, Dtype? dtype = null, int? axis = null)
            => NumPy.Instance.geomspace(start, stop, num:num, endpoint:endpoint, dtype:dtype, axis:axis);
        
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
        public static NDarray<T> geomspace<T>(T[] start, T[] stop, int? num = null, bool? endpoint = null, Dtype? dtype = null, int? axis = null)
            => NumPy.Instance.geomspace(start, stop, num:num, endpoint:endpoint, dtype:dtype, axis:axis);
        
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
        public static NDarray meshgrid(NDarray x1, x2,…, xn, {‘xy’ indexing = null, bool? sparse = null, bool? copy = null)
            => NumPy.Instance.meshgrid(x1, x2,…, xn, indexing:indexing, sparse:sparse, copy:copy);
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
        public static NDarray<T> meshgrid<T>(T[] x1, x2,…, xn, {‘xy’ indexing = null, bool? sparse = null, bool? copy = null)
            => NumPy.Instance.meshgrid(x1, x2,…, xn, indexing:indexing, sparse:sparse, copy:copy);
        */
        
        /// <summary>
        /// Extract a diagonal or construct a diagonal array.
        /// 
        /// See the more detailed documentation for numpy.diagonal if you use this
        /// function to extract a diagonal and wish to write to the resulting array;
        /// whether it returns a copy or a view depends on what version of numpy you
        /// are using.
        /// </summary>
        public static NDarray diag(NDarray v, int? k = null)
            => NumPy.Instance.diag(v, k:k);
        
        /// <summary>
        /// Extract a diagonal or construct a diagonal array.
        /// 
        /// See the more detailed documentation for numpy.diagonal if you use this
        /// function to extract a diagonal and wish to write to the resulting array;
        /// whether it returns a copy or a view depends on what version of numpy you
        /// are using.
        /// </summary>
        public static NDarray<T> diag<T>(T[] v, int? k = null)
            => NumPy.Instance.diag(v, k:k);
        
        /// <summary>
        /// Create a two-dimensional array with the flattened input as a diagonal.
        /// </summary>
        public static NDarray diagflat(NDarray v, int? k = null)
            => NumPy.Instance.diagflat(v, k:k);
        
        /// <summary>
        /// Create a two-dimensional array with the flattened input as a diagonal.
        /// </summary>
        public static NDarray<T> diagflat<T>(T[] v, int? k = null)
            => NumPy.Instance.diagflat(v, k:k);
        
        /// <summary>
        /// An array with ones at and below the given diagonal and zeros elsewhere.
        /// </summary>
        public static NDarray tri(int N, int? M = null, int? k = null, Dtype? dtype = null)
            => NumPy.Instance.tri(N, M:M, k:k, dtype:dtype);
        
        /// <summary>
        /// Lower triangle of an array.
        /// 
        /// Return a copy of an array with elements above the k-th diagonal zeroed.
        /// </summary>
        public static NDarray tril(NDarray m, int? k = null)
            => NumPy.Instance.tril(m, k:k);
        
        /// <summary>
        /// Lower triangle of an array.
        /// 
        /// Return a copy of an array with elements above the k-th diagonal zeroed.
        /// </summary>
        public static NDarray<T> tril<T>(T[] m, int? k = null)
            => NumPy.Instance.tril(m, k:k);
        
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
        public static NDarray vander(NDarray x, int? N = null, bool? increasing = null)
            => NumPy.Instance.vander(x, N:N, increasing:increasing);
        
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
        public static NDarray<T> vander<T>(T[] x, int? N = null, bool? increasing = null)
            => NumPy.Instance.vander(x, N:N, increasing:increasing);
        
        /*
        /// <summary>
        /// Interpret the input as a matrix.
        /// 
        /// Unlike matrix, asmatrix does not make a copy if the input is already
        /// a matrix or an ndarray.  Equivalent to matrix(data, copy=False).
        /// </summary>
        public static matrix mat(NDarray data, Dtype dtype)
            => NumPy.Instance.mat(data, dtype);
        */
        
        /*
        /// <summary>
        /// Interpret the input as a matrix.
        /// 
        /// Unlike matrix, asmatrix does not make a copy if the input is already
        /// a matrix or an ndarray.  Equivalent to matrix(data, copy=False).
        /// </summary>
        public static matrix mat<T>(T[] data, Dtype dtype)
            => NumPy.Instance.mat(data, dtype);
        */
        
        /*
        /// <summary>
        /// Build a matrix object from a string, nested sequence, or array.
        /// </summary>
        public static matrix bmat(string obj, Hashtable ldict = null, Hashtable gdict = null)
            => NumPy.Instance.bmat(obj, ldict:ldict, gdict:gdict);
        */
        
        /*
        /// <summary>
        /// Build a matrix object from a string, nested sequence, or array.
        /// </summary>
        public static matrix<T> bmat<T>(T[] obj, Hashtable ldict = null, Hashtable gdict = null)
            => NumPy.Instance.bmat(obj, ldict:ldict, gdict:gdict);
        */
        
        
    }
}
