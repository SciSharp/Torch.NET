![Logo](docs/art/Torch.NET_128.png)

# Torch.NET

Torch.NET brings the awesome Python package [PyTorch](https://pytorch.org) to the .NET world. PyTorch offers Tensor computations and more with efficient GPU or multi-core CPU processing support and is to be considered one of the fundamental libraries for scientific computing, machine learning and AI in Python. Torch.NET empowers .NET developers to leverage PyTorch's extensive functionality including computational graphs with with multi-dimensional arrays, back-propagation, neural network implementations and many more via a compatible strong-typed API.

## Dependencies
You need **Python 3.7** and **PyTorch** installed on your System for Torch.NET to work.

## Status

Torch.NET is currently under very busy construction. The entire torch.* API has been completed. If you execute the unit tests you'll see that tensors can be created on CPU and GPU and operations can be performed on them.

### Completion
The checked categories have been wrapped.
- [x] torch
- [x] torch.Tensor
- [x] Tensor Attributes
- [x] Type Info
- [ ] torch.sparse
- [ ] torch.cuda
- [ ] torch.Storage
- [ ] torch.nn
- [ ] torch.nn.functional
- [ ] torch.nn.init
- [ ] torch.optim
- [ ] torch.autograd
- [ ] torch.distributed
- [ ] torch.distributions
- [ ] torch.hub
- [ ] torch.jit
- [ ] torch.multiprocessing
- [ ] torch.utils.bottleneck
- [ ] torch.utils.checkpoint
- [ ] torch.utils.cpp_extension
- [ ] torch.utils.data
- [ ] torch.utils.dlpack
- [ ] torch.utils.model_zoo
- [ ] torch.utils.tensorboard (experimental)
- [ ] torch.onnx
- [ ] torch.__config__

## Release

[Torch.NET 1.0.0](https://www.nuget.org/packages/Torch.NET/1.0.0) on Nuget.org
