using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            torch.empty(2, 3);
        }
    }
}
