using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Numpy.Models;
using Python.Runtime;
using Torch;

namespace SimpleNeuralNetworkExample
{
    partial class Program
    {

        /// <summary>
        /// A fully-connected ReLU network with one hidden layer and no biases, trained
        /// to predict y from x by minimizing squared Euclidean distance.
        /// 
        /// This implementation uses PyTorch tensors to manually compute the forward pass,
        /// loss, and backward pass.
        /// 
        /// A PyTorch Tensor is basically the same as a numpy array: it does not know
        /// anything about deep learning or computational graphs or gradients, and is just
        /// a generic n-dimensional array to be used for arbitrary numeric computation.
        /// 
        /// The biggest difference between a numpy array and a PyTorch Tensor is that a
        /// PyTorch Tensor can run on either CPU or GPU. 
        /// </summary>
        /// <param name="dtype"></param>
        /// <param name="device"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private static void LearnManualBackprop(Dtype dtype, Device device, Tensor x, Tensor y)
        {
            Console.WriteLine("Manual backprop:");

            // N is batch size; D_in is input dimension;
            // H is hidden dimension; D_out is output dimension.
            var (N, D_in, H, D_out) = (64, 1000, 100, 10);

            var stopwatch = Stopwatch.StartNew();
            // Randomly initialize weights
            var w1 = torch.randn(new Shape(D_in, H), device: device, dtype: dtype);
            var w2 = torch.randn(new Shape(H, D_out), device: device, dtype: dtype);

            var learning_rate = 1.0e-6;
            for (int t = 0; t <= 500; t++)
            {
                // Forward pass: compute predicted y
                var h = x.mm(w1);
                var h_relu = h.clamp(min: 0);
                var y_pred = h_relu.mm(w2);

                // Compute and print loss
                var loss = (y_pred - y).pow(2).sum().item<double>();
                if (t % 20 == 0)
                    Console.WriteLine($"\tstep {t}: {loss:F4}");

                // Backprop to compute gradients of w1 and w2 with respect to loss
                var grad_y_pred = 2.0 * (y_pred - y);
                var grad_w2 = h_relu.t().mm(grad_y_pred);
                var grad_h_relu = grad_y_pred.mm(w2.t());
                var grad_h = grad_h_relu.clone();
                grad_h[h < 0] = (Tensor)0;
                var grad_w1 = x.t().mm(grad_h);

                // Update weights using gradient descent
                w1.isub(learning_rate * grad_w1); // "isub" is the C# equivalent for "-="
                w2.isub(learning_rate * grad_w2);
            }
            stopwatch.Stop();
            Console.WriteLine($"\telapsed time: {stopwatch.Elapsed.TotalSeconds:F3} seconds\n");
        }

    }
}
