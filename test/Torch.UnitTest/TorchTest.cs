using Microsoft.VisualStudio.TestTools.UnitTesting;
using Python.Runtime;

namespace Torch
{
    [TestClass]
    public class TorchTest
    {
        TorchRunner torch;
        [TestInitialize]
        public void Init()
        {
            torch = new TorchRunner();
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
        public void tensor()
        {
            var tensor = torch.tensor(new float[,] { { 0.1f, 1.2f }, { 2.2f, 3.1f }, { 4.9f, 5.2f } });
            Assert.IsNotNull(tensor.ToString());
        }
    }
}
