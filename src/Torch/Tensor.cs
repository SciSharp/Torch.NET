using System;
using System.Collections.Generic;
using System.Text;

namespace Torch
{
    public class Tensor : IDisposable
    {
        private IntPtr handle;
        public IntPtr Handle => handle;
        public string Name { get; set; }

        private string display;

        public Tensor(IntPtr _handle, string display = null)
        {
            handle = _handle;
            this.display = display;
        }

        public override string ToString()
        {
            return display;
        }

        public void Dispose()
        {
            
        }
    }
}
