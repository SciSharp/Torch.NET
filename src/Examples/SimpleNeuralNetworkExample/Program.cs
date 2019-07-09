using System;
using System.Diagnostics;
using Numpy.Models;
using Python.Runtime;
using Torch;

namespace SimpleNeuralNetworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\timporting torch ...");

            var dtype = torch.@float;
            var device = torch.device("cuda:0"); // "cuda:0" or "cpu"
            // N is batch size; D_in is input dimension;
            // H is hidden dimension; D_out is output dimension.

            var (N, D_in, H, D_out) = (64, 1000, 100, 10);
            // Create random Tensors to hold input and outputs.
            // Setting requires_grad=False indicates that we do not need to compute gradients
            // with respect to these Tensors during the backward pass.
            Console.WriteLine("\tcreating random data ...");
            var x = torch.randn(new Shape(N, D_in), device: device, dtype: dtype);
            var y = torch.randn(new Shape(N, D_out), device: device, dtype: dtype);

            LearnManually(dtype, device, x, y);

            LearnWithAutoGrad(dtype, device, x, y);

            Console.Write("Hit any key to exit: ");
            Console.ReadKey();
        }

        private static void LearnManually(Dtype dtype, Device device, Tensor x, Tensor y)
        {
            Console.WriteLine("Manual: fitting a two-layer NN against random data ...");

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

        private static void LearnWithAutoGrad(Dtype dtype, Device device, Tensor x, Tensor y)
        {
            Console.WriteLine("AutoGrad: fitting a two-layer NN against random data ...");

            // N is batch size; D_in is input dimension;
            // H is hidden dimension; D_out is output dimension.
            var (N, D_in, H, D_out) = (64, 1000, 100, 10);

            var stopwatch = Stopwatch.StartNew();
            // Create random Tensors for weights.
            // Setting requires_grad=true indicates that we want to compute gradients with
            // respect to these Tensors during the backward pass.
            var w1 = torch.randn(new Shape(D_in, H), device: device, dtype: dtype, requires_grad: true);
            var w2 = torch.randn(new Shape(H, D_out), device: device, dtype: dtype, requires_grad: true);

            var learning_rate = 1.0e-6;
            for (int t = 0; t <= 500; t++)
            {
                // Forward pass: compute predicted y using operations on Tensors; these
                // are exactly the same operations we used to compute the forward pass using
                // Tensors, but we do not need to keep references to intermediate values since
                // we are not implementing the backward pass by hand.
                var y_pred = x.mm(w1).clamp(min: 0).mm(w2);

                // Compute and print loss using operations on Tensors.
                // Now loss is a Tensor of shape (1,)
                // loss.item() gets the a scalar value held in the loss.
                var loss = (y_pred - y).pow(2).sum();
                if (t % 20 == 0)
                    Console.WriteLine($"\tstep {t}: {loss.item<double>():F4}");

                // Use autograd to compute the backward pass. This call will compute the
                // gradient of loss with respect to all Tensors with requires_grad=true.
                // After this call w1.grad and w2.grad will be Tensors holding the gradient
                // of the loss with respect to w1 and w2 respectively.
                loss.backward();

                // Manually update weights using gradient descent. Wrap in torch.no_grad()
                // because weights have requires_grad=true, but we don't need to track this
                // in autograd.
                // An alternative way is to operate on weight.data and weight.grad.data.
                // Recall that tensor.data gives a tensor that shares the storage with
                // tensor, but doesn't track history.
                // You can also use torch.optim.SGD to achieve this.
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
