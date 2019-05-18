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
        
        public static NDarray arange(byte start = (byte)0, byte stop, byte step = (byte)1, Dtype dtype)
            => NumPy.Instance.arange(start:start, stop, step:step, dtype:dtype);
        
        public static NDarray arange(short start = (short)0, short stop, short step = (short)1, Dtype dtype)
            => NumPy.Instance.arange(start:start, stop, step:step, dtype:dtype);
        
        public static NDarray arange(int start = 0, int stop, int step = 1, Dtype dtype)
            => NumPy.Instance.arange(start:start, stop, step:step, dtype:dtype);
        
        public static NDarray arange(long start = (long)0, long stop, long step = (long)1, Dtype dtype)
            => NumPy.Instance.arange(start:start, stop, step:step, dtype:dtype);
        
        public static NDarray arange(float start = (float)0, float stop, float step = (float)1, Dtype dtype)
            => NumPy.Instance.arange(start:start, stop, step:step, dtype:dtype);
        
        public static NDarray arange(double start = (double)0, double stop, double step = (double)1, Dtype dtype)
            => NumPy.Instance.arange(start:start, stop, step:step, dtype:dtype);
        
/*

 --------------- generator exception ---------------------
Return tuple
   at CodeMinion.Core.CodeGenerator.GenerateReturnType(Declaration decl) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 238
   at CodeMinion.Core.CodeGenerator.GenerateStaticApiRedirection(StaticApi api, Declaration decl, CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 83
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass30_0.<GenerateStaticApi>b__1() in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 334
   at CodeMinion.Core.Helpers.CodeWriter.Indent(Action a) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 58
   at CodeMinion.Core.Helpers.CodeWriter.Block(Action a, String opening_brace, String closing_brace) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 75
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass30_0.<GenerateStaticApi>b__0() in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 329
   at CodeMinion.Core.Helpers.CodeWriter.Indent(Action a) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 58
   at CodeMinion.Core.Helpers.CodeWriter.Block(Action a, String opening_brace, String closing_brace) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 75
   at CodeMinion.Core.CodeGenerator.GenerateStaticApi(StaticApi api, CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 326
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass34_0.<Generate>b__0(CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 396
   at CodeMinion.Core.CodeGenerator.WriteFile(String path, Action`1 generate_action) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 374
*/
