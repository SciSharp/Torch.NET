using Python.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Torch
{
    public partial class TorchRunner
    {
        public Tensor empty(params int[] size)
        {
            var _size = Util.ToPython<int[]>(size);
            dynamic py = torch.empty(_size);

            //return new Tensor(py.Handle);
            return Util.ToCsharp<Tensor>(py);
        }

        public Tensor tensor<T>(T[] data)
        {
            dynamic py = torch.tensor(data);
            var tensor = new Tensor(py.Handle);

            return tensor;
        }
    }
}
