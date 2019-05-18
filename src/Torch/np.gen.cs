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
        
        public static NDarray empty_like(array_like prototype, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.empty_like(prototype, dtype:dtype, order:order, subok:subok);
        
        public static NDarray eye(int N, int? M = null, int? k = null, Dtype? dtype = null, string order = null)
            => NumPy.Instance.eye(N, M:M, k:k, dtype:dtype, order:order);
        
        public static NDarray identity(int n, Dtype? dtype = null)
            => NumPy.Instance.identity(n, dtype:dtype);
        
        public static NDarray ones(NumSharp.Shape shape, Dtype? dtype = null, string order = null)
            => NumPy.Instance.ones(shape, dtype:dtype, order:order);
        
        public static NDarray ones_like(array_like a, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.ones_like(a, dtype:dtype, order:order, subok:subok);
        
        public static NDarray zeros(NumSharp.Shape shape, Dtype? dtype = null, string order = null)
            => NumPy.Instance.zeros(shape, dtype:dtype, order:order);
        
        public static NDarray zeros_like(array_like a, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.zeros_like(a, dtype:dtype, order:order, subok:subok);
        
        public static NDarray full(NumSharp.Shape shape, scalar fill_value, Dtype? dtype = null, string order = null)
            => NumPy.Instance.full(shape, fill_value, dtype:dtype, order:order);
        
        public static NDarray full_like(array_like a, scalar fill_value, Dtype? dtype = null, string order = null, bool? subok = null)
            => NumPy.Instance.full_like(a, fill_value, dtype:dtype, order:order, subok:subok);
        
        public static NDarray array(array_like @object, Dtype? dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
            => NumPy.Instance.array(@object, dtype:dtype, copy:copy, order:order, subok:subok, ndmin:ndmin);
        
        public static NDarray asarray(array_like a, Dtype? dtype = null, string order = null)
            => NumPy.Instance.asarray(a, dtype:dtype, order:order);
        
        public static NDarray asanyarray(array_like a, Dtype? dtype = null, string order = null)
            => NumPy.Instance.asanyarray(a, dtype:dtype, order:order);
        
        public static NDarray ascontiguousarray(array_like a, Dtype? dtype = null)
            => NumPy.Instance.ascontiguousarray(a, dtype:dtype);
        
        public static matrix asmatrix(array_like data, Dtype dtype)
            => NumPy.Instance.asmatrix(data, dtype);
        
        public static NDarray copy(array_like a, string order = null)
            => NumPy.Instance.copy(a, order:order);
        
        public static void frombuffer(buffer_like buffer, Dtype? dtype = null, int? count = null, int? offset = null)
            => NumPy.Instance.frombuffer(buffer, dtype:dtype, count:count, offset:offset);
        
        public static void fromfile(file or str file, Dtype dtype, int count, str sep)
            => NumPy.Instance.fromfile(file, dtype, count, sep);
        
        public static any fromfunction(callable function, NumSharp.Shape shape, Dtype? dtype = null)
            => NumPy.Instance.fromfunction(function, shape, dtype:dtype);
        
        public static NDarray fromiter(iterable object iterable, Dtype dtype, int? count = null)
            => NumPy.Instance.fromiter(iterable, dtype, count:count);
        
        public static NDarray fromstring(str @string, Dtype? dtype = null, int? count = null, str? sep = null)
            => NumPy.Instance.fromstring(@string, dtype:dtype, count:count, sep:sep);
        
        public static NDarray loadtxt(file fname, Dtype? dtype = null, str or sequence of str? comments = null, str? delimiter = null, dict? converters = null, int? skiprows = null, int or sequence? usecols = null, bool? unpack = null, int? ndmin = null, str? encoding = null, int? max_rows = null)
            => NumPy.Instance.loadtxt(fname, dtype:dtype, comments:comments, delimiter:delimiter, converters:converters, skiprows:skiprows, usecols:usecols, unpack:unpack, ndmin:ndmin, encoding:encoding, max_rows:max_rows);
        
        public static void array(array of str or unicode-like obj, int? itemsize = null, bool? copy = null, bool? unicode = null, string order = null)
            => NumPy.Instance.array(obj, itemsize:itemsize, copy:copy, unicode:unicode, order:order);
        
        public static void asarray(array of str or unicode-like obj, int? itemsize = null, bool? unicode = null, string order = null)
            => NumPy.Instance.asarray(obj, itemsize:itemsize, unicode:unicode, order:order);
        
        public static NDarray arange(number? start = null, number stop, number? step = null, Dtype dtype)
            => NumPy.Instance.arange(start:start, stop, step:step, dtype);
        
/*

 --------------- generator exception ---------------------
Return tuple
   at CodeMinion.Core.CodeGenerator.GenerateReturnType(Declaration decl) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 191
   at CodeMinion.Core.CodeGenerator.GenerateStaticApiRedirection(StaticApi api, Declaration input_decl, CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 307
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass26_0.<GenerateStaticApi>b__1() in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 287
   at CodeMinion.Core.Helpers.CodeWriter.Indent(Action a) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 55
   at CodeMinion.Core.Helpers.CodeWriter.Block(Action a, String opening_brace, String closing_brace) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 72
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass26_0.<GenerateStaticApi>b__0() in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 282
   at CodeMinion.Core.Helpers.CodeWriter.Indent(Action a) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 55
   at CodeMinion.Core.Helpers.CodeWriter.Block(Action a, String opening_brace, String closing_brace) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 72
   at CodeMinion.Core.CodeGenerator.GenerateStaticApi(StaticApi api, CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 279
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass31_0.<Generate>b__0(CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 373
   at CodeMinion.Core.CodeGenerator.WriteFile(String path, Action`1 generate_action) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 353
*/
