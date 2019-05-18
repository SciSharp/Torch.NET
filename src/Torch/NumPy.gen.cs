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
        
        public NDarray arange(byte start = (byte)0, byte stop, byte step = (byte)1, Dtype dtype)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                stop,
            });
            var kwargs=new PyDict();
            if (start!=null) kwargs["start"]=ToPython(start);
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        public NDarray arange(short start = (short)0, short stop, short step = (short)1, Dtype dtype)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                stop,
            });
            var kwargs=new PyDict();
            if (start!=null) kwargs["start"]=ToPython(start);
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        public NDarray arange(int start = 0, int stop, int step = 1, Dtype dtype)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                stop,
            });
            var kwargs=new PyDict();
            if (start!=null) kwargs["start"]=ToPython(start);
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        public NDarray arange(long start = (long)0, long stop, long step = (long)1, Dtype dtype)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                stop,
            });
            var kwargs=new PyDict();
            if (start!=null) kwargs["start"]=ToPython(start);
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        public NDarray arange(float start = (float)0, float stop, float step = (float)1, Dtype dtype)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                stop,
            });
            var kwargs=new PyDict();
            if (start!=null) kwargs["start"]=ToPython(start);
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        public NDarray arange(double start = (double)0, double stop, double step = (double)1, Dtype dtype)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                stop,
            });
            var kwargs=new PyDict();
            if (start!=null) kwargs["start"]=ToPython(start);
            if (step!=null) kwargs["step"]=ToPython(step);
            if (dtype!=null) kwargs["dtype"]=ToPython(dtype);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
/*

 --------------- generator exception ---------------------
Return tuple
   at CodeMinion.Core.CodeGenerator.GenerateReturnType(Declaration decl) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 238
   at CodeMinion.Core.CodeGenerator.GenerateApiFunction(Declaration decl, CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 55
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass32_0.<GenerateApiImpl>b__1() in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 363
   at CodeMinion.Core.Helpers.CodeWriter.Indent(Action a) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 58
   at CodeMinion.Core.Helpers.CodeWriter.Block(Action a, String opening_brace, String closing_brace) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 75
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass32_0.<GenerateApiImpl>b__0() in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 357
   at CodeMinion.Core.Helpers.CodeWriter.Indent(Action a) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 58
   at CodeMinion.Core.Helpers.CodeWriter.Block(Action a, String opening_brace, String closing_brace) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 75
   at CodeMinion.Core.CodeGenerator.GenerateApiImpl(StaticApi api, CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 354
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass34_0.<Generate>b__2(CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 398
   at CodeMinion.Core.CodeGenerator.WriteFile(String path, Action`1 generate_action) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 374
*/
