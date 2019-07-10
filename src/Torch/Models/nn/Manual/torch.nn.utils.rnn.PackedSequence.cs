using System;
using System.Collections.Generic;
using System.Text;
using Python.Runtime;

namespace Torch
{
    public static partial class torch
    {
        public static partial class nn
        {
            public static partial class utils
            {
                public static partial class rnn
                {
                    /// <summary>
                    ///	Holds the data and list of batch_sizes of a packed sequence.<br></br>
                    ///	
                    ///	All RNN modules accept packed sequences as inputs.<br></br>
                    ///	
                    ///	Note
                    ///	Instances of this class should never be created manually.<br></br>
                    ///	 They are meant
                    ///	to be instantiated by functions like pack_padded_sequence().<br></br>
                    ///	
                    ///	Batch sizes represent the number elements at each sequence step in
                    ///	the batch, not the varying sequence lengths passed to
                    ///	pack_padded_sequence().<br></br>
                    ///	  For instance, given data abc and x
                    ///	the PackedSequence would contain data axbc with
                    ///	batch_sizes=[2,1,1].
                    /// </summary>
                    public class PackedSequence : Tensor
                    {
                        public PackedSequence(Tensor data, Tensor<long> batch_sizes = null,
                            Tensor<long> sorted_indices = null,
                            Tensor<long> unsorted_indices = null) : base(data)
                        {
                            //auto-generated code, do not change
                            var nn = self.GetAttr("nn");
                            var utils = nn.GetAttr("utils");
                            var rnn = utils.GetAttr("rnn");
                            var __self__ = rnn;
                            var pyargs = ToTuple(new object[]
                            {
                                data,
                            });
                            var kwargs = new PyDict();
                            if (batch_sizes != null) kwargs["batch_sizes"] = ToPython(batch_sizes);
                            if (sorted_indices != null) kwargs["sorted_indices"] = ToPython(sorted_indices);
                            if (unsorted_indices != null) kwargs["unsorted_indices"] = ToPython(unsorted_indices);
                            dynamic py = __self__.InvokeMethod("PackedSequence", pyargs, kwargs);
                            self = py as PyObject;
                        }

                        // TODO: add these methods:

                        // def pin_memory(self):
                        //    # Why not convert `batch_sizes`?
                        //    # See NOTE [ device and dtype of a PackedSequence ]
                        //    return type(self)(self.data.pin_memory(), self.batch_sizes,
                        //                      bind(self.sorted_indices, lambda t: t.pin_memory()),
                        //                      bind(self.unsorted_indices, lambda t: t.pin_memory()))

                        //def cuda(self, *args, **kwargs):
                        //    """Returns a GPU copy if `self.data` not already on the GPU"""
                        //    if self.is_cuda:
                        //        return self
                        //    else:
                        //        # Why not convert `batch_sizes`?
                        //        # See NOTE [ device and dtype of a PackedSequence ]
                        //        return type(self)(self.data.cuda(*args, **kwargs), self.batch_sizes,
                        //                          bind(self.sorted_indices, lambda t: t.cuda(*args, **kwargs)),
                        //                          bind(self.unsorted_indices, lambda t: t.cuda(*args, **kwargs)))

                        //def cpu(self):
                        //    """Returns a CPU copy if `self.data` not already on the CPU"""
                        //    if self.is_cuda:
                        //        # Why not convert `batch_sizes`?
                        //        # See NOTE [ device and dtype of a PackedSequence ]
                        //        return type(self)(self.data.cpu(), self.batch_sizes,
                        //                          bind(self.sorted_indices, lambda t: t.cpu()),
                        //                          bind(self.unsorted_indices, lambda t: t.cpu()))
                        //    else:
                        //        return self

                        //def double(self):
                        //    r"""Returns copy with `self.data` cast to double type"""

                        //    # Why not convert `batch_sizes`?
                        //    # See NOTE [ device and dtype of a PackedSequence ]
                        //    return type(self)(self.data.double(), self.batch_sizes,
                        //                      self.sorted_indices, self.unsorted_indices)

                        //def float(self):
                        //    r"""Returns copy with `self.data` cast to float type"""

                        //    # Why not convert `batch_sizes`?
                        //    # See NOTE [ device and dtype of a PackedSequence ]
                        //    return type(self)(self.data.float(), self.batch_sizes,
                        //                      self.sorted_indices, self.unsorted_indices)

                        //def half(self):
                        //    r"""Returns copy with `self.data` cast to half type"""

                        //    # Why not convert `batch_sizes`?
                        //    # See NOTE [ device and dtype of a PackedSequence ]
                        //    return type(self)(self.data.half(), self.batch_sizes,
                        //                      self.sorted_indices, self.unsorted_indices)

                        //def long(self):
                        //    r"""Returns copy with `self.data` cast to long type"""

                        //    # Why not convert `batch_sizes`?
                        //    # See NOTE [ device and dtype of a PackedSequence ]
                        //    return type(self)(self.data.long(), self.batch_sizes,
                        //                      self.sorted_indices, self.unsorted_indices)

                        //def int(self):
                        //    r"""Returns copy with `self.data` cast to int type"""

                        //    # Why not convert `batch_sizes`?
                        //    # See NOTE [ device and dtype of a PackedSequence ]
                        //    return type(self)(self.data.int(), self.batch_sizes,
                        //                      self.sorted_indices, self.unsorted_indices)

                        //def short(self):
                        //    r"""Returns copy with `self.data` cast to short type"""

                        //    # Why not convert `batch_sizes`?
                        //    # See NOTE [ device and dtype of a PackedSequence ]
                        //    return type(self)(self.data.short(), self.batch_sizes,
                        //                      self.sorted_indices, self.unsorted_indices)

                        //def char(self):
                        //    r"""Returns copy with `self.data` cast to char type"""

                        //    # Why not convert `batch_sizes`?
                        //    # See NOTE [ device and dtype of a PackedSequence ]
                        //    return type(self)(self.data.char(), self.batch_sizes,
                        //                      self.sorted_indices, self.unsorted_indices)

                        //def byte(self):
                        //    r"""Returns copy with `self.data` cast to byte type"""

                        //    # Why not convert `batch_sizes`?
                        //    # See NOTE [ device and dtype of a PackedSequence ]
                        //    return type(self)(self.data.byte(), self.batch_sizes,
                        //                      self.sorted_indices, self.unsorted_indices)

                        //def to(self, *args, **kwargs):
                        //    r"""Performs dtype and/or device conversion on `self.data`.

                        //    It has similar signature as :meth:`torch.Tensor.to`.

                        //    .. note::

                        //        If the ``self.data`` Tensor already has the correct :class:`torch.dtype`
                        //        and :class:`torch.device`, then ``self`` is returned.
                        //        Otherwise, returns a copy with the desired configuration.
                        //    """

                        //    # Why not convert `batch_sizes`?
                        //    # See NOTE [ device and dtype of a PackedSequence ]
                        //    data = self.data.to(*args, **kwargs)
                        //    sorted_indices = self.sorted_indices
                        //    unsorted_indices = self.unsorted_indices
                        //    device_kw = 'device'
                        //    if device_kw in kwargs:
                        //        sorted_indices = bind(sorted_indices, lambda t: t.to(kwargs[device_kw]))
                        //        unsorted_indices = bind(unsorted_indices, lambda t: t.to(kwargs[device_kw]))
                        //    if data is self.data:
                        //        return self
                        //    else:
                        //        return type(self)(data, self.batch_sizes,
                        //                          sorted_indices, unsorted_indices)

                        //@property
                        //def is_cuda(self):
                        //    r"""Returns true if `self.data` stored on a gpu"""
                        //    return self.data.is_cuda

                        //def is_pinned(self):
                        //    r"""Returns true if `self.data` stored on in pinned memory"""
                        //    return self.data.is_pinned()

                    }
                }
            }
        }
    }
}
