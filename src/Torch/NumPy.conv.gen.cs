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
    public partial class NumPy : IDisposable
    {
        
        private static Lazy<NumPy> _instance = new Lazy<NumPy>(() => new NumPy());
        public static NumPy Instance => _instance.Value;
        
        Lazy<PyObject> _pyobj = new Lazy<PyObject>(() => Py.Import("numpy"));
        public dynamic self => _pyobj.Value;
        
        Lazy<PyObject> _np = new Lazy<PyObject>(() => Py.Import("numpy"));
        public dynamic np => _np.Value;
        private NumPy() { PythonEngine.Initialize(); }
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
                default: throw new NotImplementedException($"Type is not yet supported: { obj.GetType().Name}. Add it to 'ToPythonConversions'");
            }
        }
        
        //auto-generated
        protected T ToCsharp<T>(dynamic pyobj)
        {
            switch (typeof(T).Name)
            {
                // types from 'ToCsharpConversions'
                default: return (T)pyobj;
            }
        }
    }
}
