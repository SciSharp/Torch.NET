using Python.Runtime;
using System;
using System.Text;

namespace Torch
{
    public partial class TorchRunner : IDisposable
    {
        StringBuilder stats = new StringBuilder();
        dynamic torch;
        dynamic np;
        public TorchRunner()
        {
            PythonEngine.Initialize();
            torch = Py.Import("torch");
            np = Py.Import("numpy");
        }

        public void Dispose()
        {
            PythonEngine.Shutdown();
        }
    }
}
