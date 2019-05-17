using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Python.Runtime;
using Assert = NUnit.Framework.Assert;

namespace Torch
{
    [TestClass]
    public class TorchTest
    {
        TorchRunner torch;
        [TestInitialize]
        public void Init()
        {
            torch = TorchRunner.Instance;
        }

        /// <summary>
        /// do_test_empty_full
        /// test\common_utils.py
        /// </summary>
        [TestMethod]
        public void empty()
        {
            var tensor = torch.empty((2, 3));
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
            var tensor = torch.empty((2, 3), dtype:dtype.Int32);
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
    }
}
