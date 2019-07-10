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
        /// A fully-connected ReLU network with one hidden layer, trained to predict y from x by
        /// minimizing squared Euclidean distance.
        /// 
        /// This implementation uses the nn package from PyTorch to build the network.
        /// 
        /// Rather than manually updating the weights of the model as we have been doing, we
        /// use the optim package to define an Optimizer that will update the weights for us. The
        /// optim package defines many optimization algorithms that are commonly used for deep
        /// learning, including SGD+momentum, RMSProp, Adam, etc.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private static void LearnWithOptimizer(Tensor x, Tensor y)
        {
            Console.WriteLine("Using NN Modules:");

            // N is batch size; D_in is input dimension;
            // H is hidden dimension; D_out is output dimension.
            var (N, D_in, H, D_out) = (64, 1000, 100, 10);

            var stopwatch = Stopwatch.StartNew();
            // Use the nn package to define our model as a sequence of layers. nn.Sequential
            // is a Module which contains other Modules, and applies them in sequence to
            // produce its output. Each Linear Module computes output from input using a
            // linear function, and holds internal Tensors for its weight and bias.
            var model = new torch.nn.Sequential(
                new torch.nn.Linear(D_in, H),
                new torch.nn.ReLU(),
                new torch.nn.Linear(H, D_out)
            );
            model.cuda(0);

            // The nn package also contains definitions of popular loss functions; in this
            // case we will use Mean Squared Error (MSE) as our loss function.
            var loss_fn = new torch.nn.MSELoss(reduction: "sum");
            loss_fn.cuda(0);

            var learning_rate = 1.0e-4;
            var optimizer = torch.optim.Adam(model.parameters(), lr: learning_rate);
            for (int t = 0; t <= 500; t++)
            {
                // Forward pass: compute predicted y by passing x to the model.
                var y_pred = model.Invoke(x).First();

                // Compute and print loss. We pass Tensors containing the predicted and true
                // values of y, and the loss function returns a Tensor containing the
                // loss.
                var loss = loss_fn.Invoke(y_pred, y).First();
                if (t % 20 == 0)
                    Console.WriteLine($"\tstep {t}: {loss.item<double>():F4}");

                // Before the backward pass, use the optimizer object to zero all of the
                // gradients for the variables it will update (which are the learnable
                // weights of the model). This is because by default, gradients are
                // accumulated in buffers( i.e, not overwritten) whenever .backward()
                // is called. Checkout docs of torch.autograd.backward for more details.
                optimizer.zero_grad();

                // Backward pass: compute gradient of the loss with respect to model
                // parameters
                loss.backward();

                // Calling the step function on an Optimizer makes an update to its
                // parameters
                optimizer.step();
            }

            stopwatch.Stop();
            Console.WriteLine($"\telapsed time: {stopwatch.Elapsed.TotalSeconds:F3} seconds\n");
        }

    }
}
