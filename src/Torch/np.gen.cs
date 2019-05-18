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
        
        public static NDarray empty(NumSharp.Shape shape, Dtype? dtype = null, string order = null)
            => NumPy.Instance.empty(shape, dtype:dtype, order:order);
        
        public static NDarray empty_like(NDarray prototype, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.empty_like(prototype, dtype:dtype, order:order, subok:subok);
        
        public static NDarray<T> empty_like<T>(T[] prototype, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.empty_like(prototype, dtype:dtype, order:order, subok:subok);
        
        public static NDarray eye(int N, int? M = null, int? k = null, Dtype? dtype = null, string order = null)
            => NumPy.Instance.eye(N, M:M, k:k, dtype:dtype, order:order);
        
        public static NDarray identity(int n, Dtype? dtype = null)
            => NumPy.Instance.identity(n, dtype:dtype);
        
        public static NDarray ones(NumSharp.Shape shape, Dtype? dtype = null, string order = null)
            => NumPy.Instance.ones(shape, dtype:dtype, order:order);
        
        public static NDarray ones_like(NDarray a, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.ones_like(a, dtype:dtype, order:order, subok:subok);
        
        public static NDarray<T> ones_like<T>(T[] a, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.ones_like(a, dtype:dtype, order:order, subok:subok);
        
        public static NDarray zeros(NumSharp.Shape shape, Dtype? dtype = null, string order = null)
            => NumPy.Instance.zeros(shape, dtype:dtype, order:order);
        
        public static NDarray zeros_like(NDarray a, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.zeros_like(a, dtype:dtype, order:order, subok:subok);
        
        public static NDarray<T> zeros_like<T>(T[] a, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.zeros_like(a, dtype:dtype, order:order, subok:subok);
        
        public static NDarray full(NumSharp.Shape shape, ValueType fill_value, Dtype? dtype = null, string order = null)
            => NumPy.Instance.full(shape, fill_value, dtype:dtype, order:order);
        
        public static NDarray full_like(NDarray a, ValueType fill_value, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.full_like(a, fill_value, dtype:dtype, order:order, subok:subok);
        
        public static NDarray<T> full_like<T>(T[] a, ValueType fill_value, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.full_like(a, fill_value, dtype:dtype, order:order, subok:subok);
        
        public static NDarray array(NDarray @object, Dtype? dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
            => NumPy.Instance.array(@object, dtype:dtype, copy:copy, order:order, subok:subok, ndmin:ndmin);
        
        public static NDarray<T> array<T>(T[] @object, Dtype? dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
            => NumPy.Instance.array(@object, dtype:dtype, copy:copy, order:order, subok:subok, ndmin:ndmin);
        
        public static NDarray asarray(NDarray a, Dtype? dtype = null, string order = null)
            => NumPy.Instance.asarray(a, dtype:dtype, order:order);
        
        public static NDarray<T> asarray<T>(T[] a, Dtype? dtype = null, string order = null)
            => NumPy.Instance.asarray(a, dtype:dtype, order:order);
        
        public static NDarray asanyarray(NDarray a, Dtype? dtype = null, string order = null)
            => NumPy.Instance.asanyarray(a, dtype:dtype, order:order);
        
        public static NDarray<T> asanyarray<T>(T[] a, Dtype? dtype = null, string order = null)
            => NumPy.Instance.asanyarray(a, dtype:dtype, order:order);
        
        public static NDarray ascontiguousarray(NDarray a, Dtype? dtype = null)
            => NumPy.Instance.ascontiguousarray(a, dtype:dtype);
        
        public static NDarray<T> ascontiguousarray<T>(T[] a, Dtype? dtype = null)
            => NumPy.Instance.ascontiguousarray(a, dtype:dtype);
        
        public static matrix asmatrix(NDarray data, Dtype dtype)
            => NumPy.Instance.asmatrix(data, dtype);
        
        public static matrix asmatrix<T>(T[] data, Dtype dtype)
            => NumPy.Instance.asmatrix(data, dtype);
        
        public static NDarray copy(NDarray a, string order = null)
            => NumPy.Instance.copy(a, order:order);
        
        public static NDarray<T> copy<T>(T[] a, string order = null)
            => NumPy.Instance.copy(a, order:order);
        
        /*
        public static void frombuffer(buffer_like buffer, Dtype? dtype = null, int? count = null, int? offset = null)
            => NumPy.Instance.frombuffer(buffer, dtype:dtype, count:count, offset:offset);
        */
        
        public static void fromfile(string file, Dtype dtype, int count, string sep)
            => NumPy.Instance.fromfile(file, dtype, count, sep);
        
        public static object fromfunction(Delegate function, NumSharp.Shape shape, Dtype? dtype = null)
            => NumPy.Instance.fromfunction(function, shape, dtype:dtype);
        
        public static NDarray<T> fromiter<T>(IEnumerable<T> iterable, Dtype dtype, int? count = null)
            => NumPy.Instance.fromiter(iterable, dtype, count:count);
        
        public static NDarray fromstring(string @string, Dtype? dtype = null, int? count = null, string sep = null)
            => NumPy.Instance.fromstring(@string, dtype:dtype, count:count, sep:sep);
        
        public static NDarray loadtxt(string fname, Dtype? dtype = null, string[] comments = null, string delimiter = null, Hashtable converters = null, int? skiprows = null, int[] usecols = null, bool? unpack = null, int? ndmin = null, string encoding = null, int? max_rows = null)
            => NumPy.Instance.loadtxt(fname, dtype:dtype, comments:comments, delimiter:delimiter, converters:converters, skiprows:skiprows, usecols:usecols, unpack:unpack, ndmin:ndmin, encoding:encoding, max_rows:max_rows);
        
        public static void array(string[] obj, int? itemsize = null, bool? copy = null, bool? unicode = null, string order = null)
            => NumPy.Instance.array(obj, itemsize:itemsize, copy:copy, unicode:unicode, order:order);
        
        public static void asarray(string[] obj, int? itemsize = null, bool? unicode = null, string order = null)
            => NumPy.Instance.asarray(obj, itemsize:itemsize, unicode:unicode, order:order);
        
        public static NDarray arange(byte start, byte stop, byte step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(start, stop, step:step, dtype:dtype);
        
        public static NDarray arange(byte stop, byte step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(stop, step:step, dtype:dtype);
        
        public static NDarray arange(short start, short stop, short step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(start, stop, step:step, dtype:dtype);
        
        public static NDarray arange(short stop, short step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(stop, step:step, dtype:dtype);
        
        public static NDarray arange(int start, int stop, int step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(start, stop, step:step, dtype:dtype);
        
        public static NDarray arange(int stop, int step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(stop, step:step, dtype:dtype);
        
        public static NDarray arange(long start, long stop, long step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(start, stop, step:step, dtype:dtype);
        
        public static NDarray arange(long stop, long step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(stop, step:step, dtype:dtype);
        
        public static NDarray arange(float start, float stop, float step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(start, stop, step:step, dtype:dtype);
        
        public static NDarray arange(float stop, float step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(stop, step:step, dtype:dtype);
        
        public static NDarray arange(double start, double stop, double step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(start, stop, step:step, dtype:dtype);
        
        public static NDarray arange(double stop, double step = 1, Dtype? dtype = null)
            => NumPy.Instance.arange(stop, step:step, dtype:dtype);
        
        // Error generating delaration: linspace
        // Message: Return tuple
        /*
           at CodeMinion.Core.CodeGenerator.GenerateReturnType(Declaration decl) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 225
   at CodeMinion.Core.CodeGenerator.GenerateStaticApiRedirection(StaticApi api, Declaration decl, CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 83
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass30_0.<GenerateStaticApi>b__1() in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 326
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
  "DebuggerBreak": false
}
        */
        // Error generating delaration: linspace
        // Message: Return tuple
        /*
           at CodeMinion.Core.CodeGenerator.GenerateReturnType(Declaration decl) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 225
   at CodeMinion.Core.CodeGenerator.GenerateStaticApiRedirection(StaticApi api, Declaration decl, CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 83
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass30_0.<GenerateStaticApi>b__1() in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 326
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
  "DebuggerBreak": false
}
        */
        public static NDarray logspace(NDarray start, NDarray stop, int? num = null, bool? endpoint = null, float? @base = null, Dtype? dtype = null, int? axis = null)
            => NumPy.Instance.logspace(start, stop, num:num, endpoint:endpoint, @base:@base, dtype:dtype, axis:axis);
        
        public static NDarray<T> logspace<T>(T[] start, T[] stop, int? num = null, bool? endpoint = null, float? @base = null, Dtype? dtype = null, int? axis = null)
            => NumPy.Instance.logspace(start, stop, num:num, endpoint:endpoint, @base:@base, dtype:dtype, axis:axis);
        
        public static NDarray geomspace(NDarray start, NDarray stop, int? num = null, bool? endpoint = null, Dtype? dtype = null, int? axis = null)
            => NumPy.Instance.geomspace(start, stop, num:num, endpoint:endpoint, dtype:dtype, axis:axis);
        
        public static NDarray<T> geomspace<T>(T[] start, T[] stop, int? num = null, bool? endpoint = null, Dtype? dtype = null, int? axis = null)
            => NumPy.Instance.geomspace(start, stop, num:num, endpoint:endpoint, dtype:dtype, axis:axis);
        
        /*
        public static NDarray meshgrid(NDarray x1, x2,…, xn, {‘xy’ indexing = null, bool? sparse = null, bool? copy = null)
            => NumPy.Instance.meshgrid(x1, x2,…, xn, indexing:indexing, sparse:sparse, copy:copy);
        */
        
        /*
        public static NDarray<T> meshgrid<T>(T[] x1, x2,…, xn, {‘xy’ indexing = null, bool? sparse = null, bool? copy = null)
            => NumPy.Instance.meshgrid(x1, x2,…, xn, indexing:indexing, sparse:sparse, copy:copy);
        */
        
        public static NDarray diag(NDarray v, int? k = null)
            => NumPy.Instance.diag(v, k:k);
        
        public static NDarray<T> diag<T>(T[] v, int? k = null)
            => NumPy.Instance.diag(v, k:k);
        
        public static NDarray diagflat(NDarray v, int? k = null)
            => NumPy.Instance.diagflat(v, k:k);
        
        public static NDarray<T> diagflat<T>(T[] v, int? k = null)
            => NumPy.Instance.diagflat(v, k:k);
        
        public static NDarray tri(int N, int? M = null, int? k = null, Dtype? dtype = null)
            => NumPy.Instance.tri(N, M:M, k:k, dtype:dtype);
        
        public static NDarray tril(NDarray m, int? k = null)
            => NumPy.Instance.tril(m, k:k);
        
        public static NDarray<T> tril<T>(T[] m, int? k = null)
            => NumPy.Instance.tril(m, k:k);
        
        public static NDarray vander(NDarray x, int? N = null, bool? increasing = null)
            => NumPy.Instance.vander(x, N:N, increasing:increasing);
        
        public static NDarray<T> vander<T>(T[] x, int? N = null, bool? increasing = null)
            => NumPy.Instance.vander(x, N:N, increasing:increasing);
        
        /*
        public static matrix mat(NDarray data, Dtype dtype)
            => NumPy.Instance.mat(data, dtype);
        */
        
        /*
        public static matrix mat<T>(T[] data, Dtype dtype)
            => NumPy.Instance.mat(data, dtype);
        */
        
        /*
        public static matrix bmat(string obj, Hashtable ldict = null, Hashtable gdict = null)
            => NumPy.Instance.bmat(obj, ldict:ldict, gdict:gdict);
        */
        
        /*
        public static matrix<T> bmat<T>(T[] obj, Hashtable ldict = null, Hashtable gdict = null)
            => NumPy.Instance.bmat(obj, ldict:ldict, gdict:gdict);
        */
        
        
    }
}
