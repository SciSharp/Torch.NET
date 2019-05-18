using System;

namespace Torch.ApiGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var torch_gen = new TorchApiGenerator();
            torch_gen.Generate();
            var numpy_gen = new NumpyApiGenerator();
            numpy_gen.Generate();
        }
    }
}
