using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using NumSharp;

namespace Torch
{
    public partial class PyTorch : IDisposable
    {
        
        private static Lazy<PyTorch> _instance = new Lazy<PyTorch>(() => new PyTorch());
        public static PyTorch Instance => _instance.Value;
        
        Lazy<PyObject> _pyobj = new Lazy<PyObject>(() => Py.Import("torch"));
        public dynamic self => _pyobj.Value;
        
        Lazy<PyObject> _np = new Lazy<PyObject>(() => Py.Import("numpy"));
        public dynamic np => _np.Value;
        private PyTorch() { PythonEngine.Initialize(); }
        public void Dispose() { PythonEngine.Shutdown(); }
        
        
        //auto-generated
        protected PyTuple ToTuple(Array input)
        {
            var array = new PyObject[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i]=ToPython(input.GetValue(i));
            }
            return new PyTuple(array);
        }
        
        //auto-generated
        protected PyObject ToPython(object obj)
        {
            if (obj == null) return null;
            switch (obj)
            {
                // basic types
                case int o: return new PyInt(o);
                case float o: return new PyFloat(o);
                case double o: return new PyFloat(o);
                case string o: return new PyString(o);
                // sequence types
                case Array o: return ToTuple(o);
                // special types from 'ToPythonConversions'
                case NumSharp.Shape o: return ToTuple(o.Dimensions);
                case Tensor o: return o.PyObject;
                case NumSharp.NDArray o: return NDArrayToPython(o);
                default: throw new NotImplementedException($"Type is not yet supported: { obj.GetType().Name}. Add it to 'ToPythonConversions'");
            }
        }
        
        //auto-generated
        protected T ToCsharp<T>(dynamic pyobj)
        {
            switch (typeof(T).Name)
            {
                // types from 'ToCsharpConversions'
                case "Tensor": return (T)(object)new Tensor(pyobj);
                default: return (T)pyobj;
            }
        }
        
        //auto-generated: SpecialConversions
        protected PyObject NDArrayToPython(NDArray nd)
        {
            // todo: MarshalCopy
            var result = np.array(new PyTuple(new[] { ToTuple(nd.Array) }));
            if (nd.ndim == 0)
            {
                throw new NotImplementedException("Are Scalars supported here ? ");
            }
            if (nd.ndim > 1)
            {
                result = np.reshape(result, nd.shape.ToList<int>());
            }
            return result;
        }
    }
}
