using Python.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Torch
{
    public class TorchRunner : IDisposable
    {
        StringBuilder stats = new StringBuilder();
        dynamic torch;

        public TorchRunner()
        {
            stats.AppendLine("from __future__ import print_function");
            stats.AppendLine("import torch");
            stats.AppendLine("");

            PythonEngine.Initialize();
            torch = Py.Import("torch");
        }

        public void run()
        {
            //File.WriteAllText("torch_script.py", stats.ToString());
            //string result = RunCmd.Exec("torch_script.py");
        }

        public Tensor empty(params int[] dims)
        {
            dynamic py_tensor = torch.empty(dims);

            // stats.AppendLine($"torch.empty({string.Join(", ", dims)})");
            var tensor = new Tensor();
            
            return tensor;
        }

        public Tensor tensor<T>(T[] data)
        {
            dynamic py_tensor = torch.tensor(data);

            var tensor = new Tensor();

            return tensor;
        }

        public void Dispose()
        {
            PythonEngine.Shutdown();
        }
    }
}
