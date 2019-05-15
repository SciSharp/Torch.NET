using SharpYaml;
using System;
using System.IO;

namespace Torch.CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* for test, generate this piece of code for torch.empty api.
             public Tensor empty(params int[] dims)
            {
                var tuple = new PyTuple(dims.Select(x => new PyInt(x)).ToArray());
                dynamic py = torch.empty(tuple);

                return new Tensor(py.Handle);
            } */

            var parser = new Parser(new StreamReader("Declarations.yaml"));
            while (parser.MoveNext())
            {
                
            }
        }
    }
}
