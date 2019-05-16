using Python.Runtime;
using System;
using System.Text;

namespace Torch
{
    public partial class TorchRunner : IDisposable
    {
        StringBuilder stats = new StringBuilder();
        Lazy<PyObject> _torch = new Lazy<PyObject>(() => Py.Import("torch"));
        public dynamic torch => _torch.Value;
        Lazy<PyObject> _np = new Lazy<PyObject>(() => Py.Import("numpy"));
        public dynamic np => _np.Value;

        public TorchRunner()
        {
            PythonEngine.Initialize();
        }

        public void Dispose()
        {
            PythonEngine.Shutdown();
        }
    }
}
