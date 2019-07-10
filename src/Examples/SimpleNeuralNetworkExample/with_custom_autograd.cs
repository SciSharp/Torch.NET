using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Numpy.Models;
using Python.Runtime;
using Torch;

namespace SimpleNeuralNetworkExample
{
    partial class Program
    {
        /// <summary>
        /// We can implement our own custom autograd Functions by subclassing
        /// torch.autograd.Function and implementing the forward and backward passes
        /// which operate on Tensors.
        /// </summary>
        class MyReLU : torch.autograd.Function
        {
            public override Tensor forward(Context ctx, Tensor input)
            {

            }

            public override Tensor backward(Context ctx, Tensor input)
            {

            }
        }

        /// <summary>
        /// A fully-connected ReLU network with one hidden layer and no biases, trained to
        /// predict y from x by minimizing squared Euclidean distance.
        /// 
        /// This implementation computes the forward pass using operations on PyTorch Variables,
        /// and uses PyTorch autograd to compute gradients.
        /// 
        /// In this implementation we implement our own custom autograd function to perform the
        /// ReLU function.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private static void LearnWithCustomAutoGrad(Dtype dtype, Device device, Tensor x, Tensor y)
        {
            Console.WriteLine("Using custom autograd function:");

            // N is batch size; D_in is input dimension;
            // H is hidden dimension; D_out is output dimension.
            var (N, D_in, H, D_out) = (64, 1000, 100, 10);

            var stopwatch = Stopwatch.StartNew();

            var w1 = torch.randn(new Shape(D_in, H), device: device, dtype: dtype, requires_grad: true);
            var w2 = torch.randn(new Shape(H, D_out), device: device, dtype: dtype, requires_grad: true);

            var learning_rate = 1.0e-6;
            for (int t = 0; t <= 500; t++)
            {
                // To apply our Function, we use Function.apply method. We alias this as 'relu'.
                var relu = new MyReLU().apply;

                // Forward pass: compute predicted y using operations; we compute
                // ReLU using our custom autograd operation.
                var y_pred = relu(x.mm(w1)).mm(w2);

                // Compute and print loss. 
                var loss = (y_pred - y).pow(2).sum();
                if (t % 20 == 0)
                    Console.WriteLine($"\tstep {t}: {loss.item<double>():F4}");

                // Use autograd to compute the backward pass.
                loss.backward();

                // Update the weights using gradient descent.
                Py.With(torch.no_grad(), _ =>
                {
                    w1.isub(learning_rate * w1.grad); // "isub" is the C# equivalent for "-="
                    w2.isub(learning_rate * w2.grad);

                    // Manually zero the gradients after updating weights
                    w1.grad.zero_();
                    w2.grad.zero_();
                });
            }

            stopwatch.Stop();
            Console.WriteLine($"\telapsed time: {stopwatch.Elapsed.TotalSeconds:F3} seconds\n");
        }

    }
}
