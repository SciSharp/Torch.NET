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
        
        public NDarray empty_like(array_like prototype, Dtype? dtype = null, string order = null, bool? subok = null)
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
        
        public NDarray ones_like(array_like a, Dtype? dtype = null, string order = null, bool? subok = null)
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
        
        public NDarray zeros_like(array_like a, Dtype? dtype = null, string order = null, bool? subok = null)
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
        
        public NDarray full(NumSharp.Shape shape, scalar fill_value, Dtype? dtype = null, string order = null)
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
        
        public NDarray full_like(array_like a, scalar fill_value, Dtype? dtype = null, string order = null, bool? subok = null)
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
        
        public NDarray array(array_like @object, Dtype? dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
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
        
        public NDarray asarray(array_like a, Dtype? dtype = null, string order = null)
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
        
        public NDarray asanyarray(array_like a, Dtype? dtype = null, string order = null)
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
        
        public NDarray ascontiguousarray(array_like a, Dtype? dtype = null)
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
        
        public matrix asmatrix(array_like data, Dtype dtype)
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
        
        public NDarray copy(array_like a, string order = null)
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
        
        public void fromfile(file or str file, Dtype dtype, int count, str sep)
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
        
        public any fromfunction(callable function, NumSharp.Shape shape, Dtype? dtype = null)
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
            return ToCsharp<any>(py);
        }
        
        public NDarray fromiter(iterable object iterable, Dtype dtype, int? count = null)
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
            return ToCsharp<NDarray>(py);
        }
        
        public NDarray fromstring(str @string, Dtype? dtype = null, int? count = null, str? sep = null)
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
        
        public NDarray loadtxt(file fname, Dtype? dtype = null, str or sequence of str? comments = null, str? delimiter = null, dict? converters = null, int? skiprows = null, int or sequence? usecols = null, bool? unpack = null, int? ndmin = null, str? encoding = null, int? max_rows = null)
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
        
        public void array(array of str or unicode-like obj, int? itemsize = null, bool? copy = null, bool? unicode = null, string order = null)
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
        
        public void asarray(array of str or unicode-like obj, int? itemsize = null, bool? unicode = null, string order = null)
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
        
        public NDarray arange(number? start = null, number stop, number? step = null, Dtype dtype)
        {
            //auto-generated code, do not change
            var args=ToTuple(new object[]
            {
                stop,
                dtype,
            });
            var kwargs=new PyDict();
            if (start!=null) kwargs["start"]=ToPython(start);
            if (step!=null) kwargs["step"]=ToPython(step);
            dynamic py = self.InvokeMethod("arange", args, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
/*

 --------------- generator exception ---------------------
Return tuple
   at CodeMinion.Core.CodeGenerator.GenerateReturnType(Declaration decl) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 192
   at CodeMinion.Core.CodeGenerator.GenerateApiFunction(Declaration input_decl, CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 50
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass29_0.<GenerateApiImpl>b__1() in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 331
   at CodeMinion.Core.Helpers.CodeWriter.Indent(Action a) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 58
   at CodeMinion.Core.Helpers.CodeWriter.Block(Action a, String opening_brace, String closing_brace) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 75
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass29_0.<GenerateApiImpl>b__0() in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 326
   at CodeMinion.Core.Helpers.CodeWriter.Indent(Action a) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 58
   at CodeMinion.Core.Helpers.CodeWriter.Block(Action a, String opening_brace, String closing_brace) in D:\dev\CodeMinion\src\CodeMinion.Core\Helpers\CodeWriter.cs:line 75
   at CodeMinion.Core.CodeGenerator.GenerateApiImpl(StaticApi api, CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 324
   at CodeMinion.Core.CodeGenerator.<>c__DisplayClass31_0.<Generate>b__2(CodeWriter s) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 366
   at CodeMinion.Core.CodeGenerator.WriteFile(String path, Action`1 generate_action) in D:\dev\CodeMinion\src\CodeMinion.Core\CodeGenerator.cs:line 342
*/
