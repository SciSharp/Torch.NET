using System;
using System.Collections.Generic;
using System.Text;

namespace Torch
{
    public class Tensor : IDisposable
    {
        private IntPtr handle;
        public string Name { get; set; }

        public Tensor(IntPtr _handle)
        {
            handle = _handle;
        }

        public void Dispose()
        {
            
        }
    }
}
