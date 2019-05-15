using Python.Runtime;
using System;
using System.Text;

namespace Torch
{
    public partial class TorchRunner : IDisposable
    {
        StringBuilder stats = new StringBuilder();
        dynamic torch;

        public TorchRunner()
        {
            PythonEngine.Initialize();
            torch = Py.Import("torch");
        }

        public void Dispose()
        {
            PythonEngine.Shutdown();
        }
    }
}
