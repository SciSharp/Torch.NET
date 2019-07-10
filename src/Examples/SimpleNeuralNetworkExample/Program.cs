using System;
using System.Diagnostics;
using System.Linq;
using Numpy.Models;
using Python.Runtime;
using Torch;

namespace SimpleNeuralNetworkExample
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Importing torch ...");

            var dtype = torch.@float;
            var device = torch.device("cuda:0"); // "cuda:0" or "cpu"
            // N is batch size; D_in is input dimension;
            // H is hidden dimension; D_out is output dimension.

            var (N, D_in, H, D_out) = (64, 1000, 100, 10);
            // Create random Tensors to hold input and outputs.
            // Setting requires_grad=False indicates that we do not need to compute gradients
            // with respect to these Tensors during the backward pass.
            Console.WriteLine("Creating random data ...");
            var x = torch.randn(new Shape(N, D_in), device: device, dtype: dtype);
            var y = torch.randn(new Shape(N, D_out), device: device, dtype: dtype);

            LearnManualBackprop(dtype, device, x, y);

            LearnWithAutoGrad(dtype, device, x, y);

            LearnWithNnModules(x, y);

            LearnWithCustomAutoGrad(dtype, device, x, y);

            LearnWithOptimizer(x, y);

            Console.Write("Hit any key to exit: ");
            Console.ReadKey();
        }


    }
}
