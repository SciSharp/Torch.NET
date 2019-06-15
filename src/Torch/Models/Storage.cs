using Python.Runtime;

namespace Torch
{
    public partial class Storage : PythonObject
    {
        public Storage(PyObject pyobj) : base(pyobj)
        {
        }

    }
}