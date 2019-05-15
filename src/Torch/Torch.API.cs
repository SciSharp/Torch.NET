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
        public Tensor empty(params int[] dims)
        {
            var tuple = new PyTuple(dims.Select(x => new PyInt(x)).ToArray());
            dynamic py = torch.empty(tuple);

            return new Tensor(py.Handle);
        }

        public Tensor tensor<T>(T[] data)
        {
            dynamic py = torch.tensor(data);
            var tensor = new Tensor(py.Handle);

            return tensor;
        }
    }
}
