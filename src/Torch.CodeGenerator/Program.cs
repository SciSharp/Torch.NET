using System;

namespace Torch.CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //var generator = new CodeGeneratorFromYaml();
            var generator = new CodeGeneratorFromHtml();
            var code = generator.Generate();
            Console.WriteLine("Generated code:\r\n");
            Console.WriteLine(code);
            Console.ReadKey();
        }
    }
}
