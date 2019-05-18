using System;

namespace Torch.ApiGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //var generator = new TorchApiGenerator();
            //generator.Generate();
            var generator1 = new NumpyApiGenerator();
            generator1.Generate();
        }
    }
}
