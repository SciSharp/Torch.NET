using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numpy.Models;
using Python.Runtime;
using Assert = NUnit.Framework.Assert;

namespace Torch
{
    [TestClass]
    public class TorchTest
    {
        /// <summary>
        /// do_test_empty_full
        /// test\common_utils.py
        /// </summary>
        [TestMethod]
        public void empty()
        {
            var tensor = torch.empty(new Shape(2, 3));
            Assert.IsNotNull(tensor.ToString());
        }

        [TestMethod]
        public void tensor_int()
        {
            var tensor = torch.tensor(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            Assert.IsNotNull(tensor.ToString());
            Console.WriteLine(tensor);
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, tensor.GetData());
            
        }
        [TestMethod]
        public void tensor_jagged_float()
        {
            var tensor = torch.tensor(new float[,] { { 0.1f, 1.2f }, { 2.2f, 3.1f }, { 4.9f, 5.2f } });
            Assert.IsNotNull(tensor.ToString());
            Console.WriteLine(tensor);
        }

        [TestMethod]
        public void efficient_array_copy()
        {
            var tensor = torch.empty(new Shape(2, 3), dtype:torch.int32);
            Console.WriteLine(tensor.ToString());
            var storage=tensor.PyObject.storage();
            Console.WriteLine("storage:"+storage);
            long ptr = storage.data_ptr();
            Console.WriteLine("ptr:"+ptr);
            var array = new int[]{1, 2, 3, 4, 5, 6};
            Marshal.Copy(array, 0, new IntPtr(ptr), array.Length);
            Console.WriteLine(tensor.ToString());
            Console.WriteLine("storage.is_pinned: " + storage.is_pinned());
            Console.WriteLine("storage:" + storage);
        }

        [TestMethod]
        public void Indexing()
        {
            //>>> x = torch.tensor([[1, 2, 3], [4, 5, 6]])
            //>>> print(x[1][2])
            //tensor(6)
            //>>> x[0][1] = 8
            //>>> print(x)
            //tensor([[ 1,  8,  3],
            //        [ 4,  5,  6]])

            var x = torch.tensor(new[,] {{1, 2, 3}, {4, 5, 6}}, dtype:torch.@long);
            Assert.AreEqual("tensor(6)", x[1][2].repr);

            x[0][1] = (Tensor) 8;
            var expected="tensor([[1, 8, 3],\n"+
            "        [4, 5, 6]])";
            Assert.AreEqual(expected, x.repr);

            //>>> x = torch.tensor([[1]])
            //>>> x
            //tensor([[1]])
            //>>> x.item()
            //1
            //>>> x = torch.tensor(2.5)
            //>>> x
            //tensor(2.5000)
            //>>> x.item()
            //2.5
            x = torch.tensor(new[,] { { 1 } }, dtype: torch.@long);
            Assert.AreEqual("tensor([[1]])", x.repr);
            Assert.AreEqual(1, x.item<long>());
        }

        [TestMethod]
        public void RequireGrad()
        {
            //>>> x = torch.tensor([[1., -1.], [1., 1.]], requires_grad=True)
            //>>> out = x.pow(2).sum()
            //>>> out.backward()
            //>>> x.grad
            //tensor([[ 2.0000, -2.0000],
            //        [ 2.0000,  2.0000]])
#if TODO
            

            var x = torch.tensor(new[,] { { 1.0, -1.0 }, { 1.0, 1.0 } }, requires_grad:true);
            var @out = x.pow(2).sum();
            @out.backward();
            var given=x.grad;
            var expected = "tensor([[ 2.0000, -2.0000],\n" +
                           "        [ 2.0000,  2.0000]])";
            Assert.AreEqual(expected, given.repr);
#endif
        }

        [TestMethod]
        public void Device()
        {
            //>>> torch.device('cuda:0')
            //device(type= 'cuda', index= 0)
            Assert.AreEqual("cuda:0", torch.device("cuda:0").repr);

            //>>> torch.device('cpu')
            //device(type= 'cpu')
            Assert.AreEqual("cpu", torch.device("cpu").repr);

            //>>> torch.device('cuda')  # current cuda device
            //device(type= 'cuda')
            Assert.AreEqual("cuda", torch.device("cuda").repr);

            //>>> # Example of a function that takes in a torch.device
            //>>> cuda1 = torch.device('cuda:1')
            //>>> torch.randn((2, 3), device = cuda1)
            //>>> # You can substitute the torch.device with a string
            //>>> torch.randn((2, 3), device = 'cuda:1')

            var cuda1 = torch.device("cuda:0");
            torch.zeros(new Shape(2, 3), device: cuda1);
            var given=torch.zeros(new Shape(2, 3), device: "cuda:0");
            var expected = "tensor([[0., 0., 0.],\n" +
                           "        [0., 0., 0.]], device='cuda:0')";
            Assert.AreEqual(expected, given.repr);

            // legacy
            Assert.AreEqual("cuda:0", torch.device(0).repr);
        }

        [TestMethod]
        public void stride()
        {
            //>>> x = torch.Tensor([[1, 2, 3, 4, 5], [6, 7, 8, 9, 10]])
            //>>> x.stride()
            //(5, 1)
            var x = new Tensor(new long[,] {{1, 2, 3, 4, 5}, {6, 7, 8, 9, 10}});
            Assert.AreEqual(new Shape(5,1), x.stride());

            //>>> x.t().stride()
            //(1, 5)
            Assert.AreEqual(new Shape(1, 5), x.t().stride());

        }
    }
}
