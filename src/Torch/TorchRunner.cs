using Python.Runtime;
using System;
using System.Text;

namespace Torch
{
    public partial class TorchRunner : IDisposable
    {
        private static Lazy<TorchRunner> _self = new Lazy<TorchRunner>(() => new TorchRunner());
        public static TorchRunner Instance => _self.Value;

        StringBuilder stats = new StringBuilder();
        Lazy<PyObject> _torch = new Lazy<PyObject>(() => Py.Import("torch"));
        public dynamic torch => _torch.Value;
        Lazy<PyObject> _np = new Lazy<PyObject>(() => Py.Import("numpy"));
        public dynamic np => _np.Value;

        private TorchRunner()
        {
            PythonEngine.Initialize();
        }

        public void Dispose()
        {
            PythonEngine.Shutdown();
        }
    }
}
