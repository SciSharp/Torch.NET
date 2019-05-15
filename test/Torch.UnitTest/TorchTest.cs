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
            var tensor = torch.empty(2, 3);
        }

        [TestMethod]
        public void tensor()
        {
            var tensor = torch.tensor(new int[] { 1, 2, 3 });
        }
    }
}
