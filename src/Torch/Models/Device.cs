using Python.Runtime;

namespace Torch
{
    public partial class Device : PythonObject
    {
        public Device(PyObject pyobj) : base(pyobj)
        {
        }

        public static implicit operator Device(string device)
        {
            if (device == null)
                return null;
            return torch.device(device);
        }
    }
}