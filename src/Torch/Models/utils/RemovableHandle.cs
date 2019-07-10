using Python.Runtime;

namespace Torch
{
    public static partial class torch
    {
        public static partial class utils
        {
            public static partial class hooks
            {
                public partial class RemovableHandle : PythonObject
                {
                    public RemovableHandle(PyObject pyobj) : base(pyobj)
                    {
                    }

                    public void remove()
                    {
                        self.InvokeMethod("remove");
                    }
                }
            }
        }
    }
}