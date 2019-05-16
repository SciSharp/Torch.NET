using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NumSharp;
using Python.Runtime;

namespace Torch
{
    public partial class TorchRunner
    {
        public PyTuple ToTuple(Array input)
        {
            var array = new PyObject[input.Length];
            for (int i = 0; i < input.Length; i++)
                array[i]=ToPython(input.GetValue(i));
            return new PyTuple(array);
        }

        public PyObject ToPython(object obj)
        {
            if (obj == null)
                return null;

            switch (obj)
            {
                // basic types
                case int o: return new PyInt(o);
                case float o: return new PyFloat(o);
                case double o: return new PyFloat(o);
                case string o: return new PyString(o);
                // sequence types
                case Array o: return ToTuple(o);
                // other types
                case NumSharp.Shape o: return ToTuple(o.Dimensions);
                case Torch.Tensor o: return new PyObject( o.Handle);
                case NumSharp.NDArray o: return NDArrayToPython(o);
                default:
                    throw new NotImplementedException("Type is not yet supported: " + obj.GetType().Name);
            }
        }

        private PyObject NDArrayToPython(NDArray nd)
        {         
            var result = np.array(new PyTuple(new []{ToTuple(nd.Array)}));
            if (nd.ndim==0)
                throw new NotImplementedException("Are Scalars supported here?");
            if (nd.ndim > 1)
            {
                var shape = result.shape;
                var ndims = result.ndim;
                result = np.reshape(result, nd.shape.ToList<int>());
            }

            return result;
        }

        public T ToCsharp<T>(dynamic pyobj)
        {
            switch (typeof(T).Name)
            {
                case "Tensor": return (T)(object)new Tensor(pyobj.Handle, pyobj.ToString());
                default: return (T) pyobj;
            }
        }
    }
}
