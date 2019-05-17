using System;

namespace Torch.CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //var generator = new CodeGeneratorFromYaml();
            var generator = new TorchApiGenerator();
            generator.Generate();
        }
    }
}
