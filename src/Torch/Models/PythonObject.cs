using System;
using System.Collections.Generic;
using System.Text;
using Python.Runtime;

namespace Torch
{
    public partial class PythonObject : IDisposable
    {
        protected PyObject self; // must not be readonly for derived constructors will need to overwrite it.
        public dynamic PyObject => self;

        public IntPtr Handle => self.Handle;

        public PythonObject(PyObject pyobject)
        {
            this.self = pyobject;
        }

        public PythonObject(Tensor t)
        {
            this.self = t.PyObject;
        }

        protected PythonObject()
        {
            // setting intermediate self for derived constructors to be able to call the python constructor on self
            self = PyTorch.Instance.self;
        }

        public static bool operator ==(PythonObject a, object b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (ReferenceEquals(a, null))
                return false;
            if (ReferenceEquals(b, null))
                return false;
            return a.Equals(b);
        }

        public static bool operator !=(PythonObject a, object b)
        {
            if (ReferenceEquals(a, b))
                return false;
            if (ReferenceEquals(a, null))
                return true;
            if (ReferenceEquals(b, null))
                return true;
            return !a.Equals(b);
        }

        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case PythonObject other:
                    return self.Equals(other.self);
                case PyObject other:
                    return self.Equals(other);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return self.GetHashCode();
        }

        // there is no need for this yet. if it is, we'll generate it automatically
        public object FromPython(PyObject obj)
        {
            if (obj.IsNone())
                return null;
            var python_typename = Runtime.PyObject_GetTypeName(obj.Handle);
            switch (python_typename)
            {
                case "Tensor": return new Tensor(obj);
                default: throw new NotImplementedException($"Type is not yet supported: { python_typename}. Add it to 'FromPythonConversions'");
            }
            return obj;
        }

        public string repr => ToString();

        public override string ToString()
        {
            return self.ToString();
        }

        /// <summary>
        /// Returns True if obj is a PyTorch tensor.
        /// </summary>
        public bool is_tensor
            => PyTorch.Instance.is_tensor(this);

        /// <summary>
        /// Returns True if obj is a PyTorch storage object.
        /// </summary>
        public bool is_storage
            => PyTorch.Instance.is_storage(this);

        public void Dispose()
        {
            self?.Dispose();
        }
    }
}
