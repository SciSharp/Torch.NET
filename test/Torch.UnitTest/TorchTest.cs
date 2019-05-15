using Microsoft.VisualStudio.TestTools.UnitTesting;
using Python.Runtime;

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
            var torch = new TorchRunner();
            var tensor = torch.empty(2, 3);
            
            torch.run();
        }

        [TestMethod]
        public void tensor()
        {
            var torch = new TorchRunner();
            var tensor = torch.tensor(new int[] { 1, 2, 3 });
            torch.run();
        }
    }
}
