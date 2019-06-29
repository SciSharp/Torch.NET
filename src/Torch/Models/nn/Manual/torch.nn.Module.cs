using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy;
using Numpy.Models;

namespace Torch
{
    public static partial class torch {
        public static partial class nn {
            /// <summary>
            /// Base class for all neural network modules.
            /// 
            /// Your models should also subclass this class.
            /// 
            /// Modules can also contain other Modules, allowing to nest them in
            /// a tree structure. You can assign the submodules as regular attributes:
            /// 
            /// import torch.nn as nn
            /// import torch.nn.functional as F
            /// 
            /// class Model(nn.Module):
            ///     def __init__(self):
            ///         super(Model, self).__init__()
            ///         self.conv1 = nn.Conv2d(1, 20, 5)
            ///         self.conv2 = nn.Conv2d(20, 20, 5)
            /// 
            ///     def forward(self, x):
            ///        x = F.relu(self.conv1(x))
            ///        return F.relu(self.conv2(x))
            /// 
            /// Submodules assigned in this way will be registered, and will have their
            /// parameters converted too when you call to(), etc.
            /// </summary>
            public class Module : PythonObject
            {
                
                public Module(PyObject pyobj) : base(pyobj) { }
                public Module(PythonObject other) : base(other.PyObject as PyObject) { }

                protected Module() : base() { }

                // TODO: every module is callable. it should have a Invoke(...) function

                /// <summary>
                /// Adds a child module to the current module.
                /// 
                /// The module can be accessed as an attribute using the given name.
                /// </summary>
                /// <param name="name">
                /// name of the child module. The child module can be
                /// accessed from this module using the given name
                /// </param>
                /// <param name="module">
                /// child module to be added to the module.
                /// </param>
                public void add_module(string name, Module module)
                {
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                        name,
                        module,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("add_module", pyargs, kwargs);
                }
                
                /// <summary>
                /// Applies fn recursively to every submodule (as returned by .children())
                /// as well as self. Typical use includes initializing the parameters of a model
                /// (see also torch-nn-init).
                /// </summary>
                public Module apply(Action<Module> fn)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                        fn,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("apply", pyargs, kwargs);
                    return ToCsharp<Module>(py);
                }
                
                /// <summary>
                /// Returns an iterator over module buffers.
                /// </summary>
                public IEnumerable<Tensor> buffers(bool recurse = true)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                    });
                    var kwargs=new PyDict();
                    if (recurse!=true) kwargs["recurse"]=ToPython(recurse);
                    dynamic py = __self__.InvokeMethod("buffers", pyargs, kwargs);
                    return ToCsharp<IEnumerable<Tensor>>(py);
                }
                
                /// <summary>
                /// Returns an iterator over immediate children modules.
                /// </summary>
                public IEnumerable<Module> children()
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    dynamic py = __self__.InvokeMethod("children");
                    return ToCsharp<IEnumerable<Module>>(py);
                }
                
                /// <summary>
                /// Moves all model parameters and buffers to the CPU.
                /// </summary>
                public Module cpu()
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    dynamic py = __self__.InvokeMethod("cpu");
                    return ToCsharp<Module>(py);
                }
                
                /// <summary>
                /// Moves all model parameters and buffers to the GPU.
                /// 
                /// This also makes associated parameters and buffers different objects. So
                /// it should be called before constructing optimizer if the module will
                /// live on GPU while being optimized.
                /// </summary>
                public Module cuda(int? device = null)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                    });
                    var kwargs=new PyDict();
                    if (device!=null) kwargs["device"]=ToPython(device);
                    dynamic py = __self__.InvokeMethod("cuda", pyargs, kwargs);
                    return ToCsharp<Module>(py);
                }
                
                /// <summary>
                /// Casts all floating point parameters and buffers to double datatype.
                /// </summary>
                public Module @double()
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    dynamic py = __self__.InvokeMethod("double");
                    return ToCsharp<Module>(py);
                }
                
                /// <summary>
                /// This allows better BC support for load_state_dict(). In
                /// state_dict(), the version number will be saved as in the attribute
                /// _metadata of the returned state dict, and thus pickled. _metadata is a
                /// dictionary with keys that follow the naming convention of state dict. See
                /// _load_from_state_dict on how to use this information in loading.
                /// 
                /// If new parameters/buffers are added/removed from a module, this number shall
                /// be bumped, and the module’s _load_from_state_dict method can compare the
                /// version number and do appropriate changes if the state dict is from before
                /// the change.
                /// </summary>
                public bool dump_patches
                {
                    get
                    {
                        dynamic py = self.GetAttr("dump_patches");
                        return ToCsharp<bool>(py);
                    }
                    set
                    {
                        self.SetAttr("dump_patches", ToPython(value));
                    }
                }
                
                /// <summary>
                /// Sets the module in evaluation mode.
                /// 
                /// This has any effect only on certain modules. See documentations of
                /// particular modules for details of their behaviors in training/evaluation
                /// mode, if they are affected, e.g. Dropout, BatchNorm,
                /// etc.
                /// </summary>
                public void eval()
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    dynamic py = __self__.InvokeMethod("eval");
                }
                
                /// <summary>
                /// Set the extra representation of the module
                /// 
                /// To print customized extra information, you should reimplement
                /// this method in your own modules. Both single-line and multi-line
                /// strings are acceptable.
                /// </summary>
                public void extra_repr()
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    dynamic py = __self__.InvokeMethod("extra_repr");
                }
                
                /// <summary>
                /// Casts all floating point parameters and buffers to float datatype.
                /// </summary>
                public Module @float()
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    dynamic py = __self__.InvokeMethod("float");
                    return ToCsharp<Module>(py);
                }

                /// <summary>
                /// Defines the computation performed at every call.
                /// 
                /// Should be overridden by all subclasses.
                /// 
                /// Note
                /// Although the recipe for forward pass needs to be defined within
                /// this function, one should call the Module instance afterwards
                /// instead of this since the former takes care of running the
                /// registered hooks while the latter silently ignores them.
                /// </summary>
                public virtual void forward(params Tensor[] inputs)
                {
                    throw new NotImplementedException("This function should be overwritten!");
                }

                /// <summary>
                /// Casts all floating point parameters and buffers to half datatype.
                /// </summary>
                public Module half()
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    dynamic py = __self__.InvokeMethod("half");
                    return ToCsharp<Module>(py);
                }
                
                /// <summary>
                /// Copies parameters and buffers from state_dict into
                /// this module and its descendants. If strict is True, then
                /// the keys of state_dict must exactly match the keys returned
                /// by this module’s state_dict() function.
                /// </summary>
                /// <param name="state_dict">
                /// a dict containing parameters and
                /// persistent buffers.
                /// </param>
                /// <param name="strict">
                /// whether to strictly enforce that the keys
                /// in state_dict match the keys returned by this module’s
                /// state_dict() function. Default: True
                /// </param>
                public (string[], string[]) load_state_dict(Hashtable state_dict, bool? strict = true)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                        state_dict,
                    });
                    var kwargs=new PyDict();
                    if (strict!=true) kwargs["strict"]=ToPython(strict);
                    dynamic py = __self__.InvokeMethod("load_state_dict", pyargs, kwargs);
                    var t = py as PyTuple;
                    return (ToCsharp<string[]>(t[0]), ToCsharp<string[]>(t[1]));
                }
                
                /// <summary>
                /// Returns an iterator over all modules in the network.
                /// </summary>
                public IEnumerable<Module> modules()
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    dynamic py = __self__.InvokeMethod("modules");
                    return ToCsharp<IEnumerable<Module>>(py);
                }
                
                /// <summary>
                /// Returns an iterator over module buffers, yielding both the
                /// name of the buffer as well as the buffer itself.
                /// </summary>
                /// <param name="prefix">
                /// prefix to prepend to all buffer names.
                /// </param>
                /// <param name="recurse">
                /// if True, then yields buffers of this module
                /// and all submodules. Otherwise, yields only buffers that
                /// are direct members of this module.
                /// </param>
                public IEnumerable<KeyValuePair<string, Tensor>> named_buffers(string prefix = "", bool recurse = true)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                    });
                    var kwargs=new PyDict();
                    if (prefix!="") kwargs["prefix"]=ToPython(prefix);
                    if (recurse!=true) kwargs["recurse"]=ToPython(recurse);
                    dynamic py = __self__.InvokeMethod("named_buffers", pyargs, kwargs);
                    return ToCsharp<IEnumerable<KeyValuePair<string, Tensor>>>(py);
                }
                
                /// <summary>
                /// Returns an iterator over immediate children modules, yielding both
                /// the name of the module as well as the module itself.
                /// </summary>
                public IEnumerable<KeyValuePair<string, Tensor>> named_children()
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    dynamic py = __self__.InvokeMethod("named_children");
                    return ToCsharp<IEnumerable<KeyValuePair<string, Tensor>>>(py);
                }
                
                /// <summary>
                /// Returns an iterator over all modules in the network, yielding
                /// both the name of the module as well as the module itself.
                /// </summary>
                public IEnumerable<KeyValuePair<string, Tensor>> named_modules(HashSet<object> memo = null, string prefix = "")
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                    });
                    var kwargs=new PyDict();
                    if (memo!=null) kwargs["memo"]=ToPython(memo);
                    if (prefix!="") kwargs["prefix"]=ToPython(prefix);
                    dynamic py = __self__.InvokeMethod("named_modules", pyargs, kwargs);
                    return ToCsharp<IEnumerable<KeyValuePair<string, Tensor>>>(py);
                }
                
                /// <summary>
                /// Returns an iterator over module parameters, yielding both the
                /// name of the parameter as well as the parameter itself.
                /// </summary>
                /// <param name="prefix">
                /// prefix to prepend to all parameter names.
                /// </param>
                /// <param name="recurse">
                /// if True, then yields parameters of this module
                /// and all submodules. Otherwise, yields only parameters that
                /// are direct members of this module.
                /// </param>
                public IEnumerable<KeyValuePair<string, Tensor>> named_parameters(string prefix = "", bool recurse = true)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                    });
                    var kwargs=new PyDict();
                    if (prefix!="") kwargs["prefix"]=ToPython(prefix);
                    if (recurse!=true) kwargs["recurse"]=ToPython(recurse);
                    dynamic py = __self__.InvokeMethod("named_parameters", pyargs, kwargs);
                    return ToCsharp<IEnumerable<KeyValuePair<string, Tensor>>>(py);
                }
                
                /// <summary>
                /// Returns an iterator over module parameters.
                /// 
                /// This is typically passed to an optimizer.
                /// </summary>
                public IEnumerable<Parameter> parameters(bool recurse = true)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                    });
                    var kwargs=new PyDict();
                    if (recurse!=true) kwargs["recurse"]=ToPython(recurse);
                    dynamic py = __self__.InvokeMethod("parameters", pyargs, kwargs);
                    return ToCsharp<IEnumerable<Parameter>>(py);
                }
                
                /// <summary>
                /// Registers a backward hook on the module.
                /// 
                /// The hook will be called every time the gradients with respect to module
                /// inputs are computed. The hook should have the following signature:
                /// 
                /// hook(module, grad_input, grad_output) -&gt; Tensor or None
                /// 
                /// The grad_input and grad_output may be tuples if the
                /// module has multiple inputs or outputs. The hook should not modify its
                /// arguments, but it can optionally return a new gradient with respect to
                /// input that will be used in place of grad_input in subsequent
                /// computations.
                /// </summary>
                public utils.hooks.RemovableHandle register_backward_hook(Func<Module, Tensor[], Tensor[], Tensor> hook)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                        hook,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("register_backward_hook", pyargs, kwargs);
                    return ToCsharp<utils.hooks.RemovableHandle>(py);
                }
                
                /// <summary>
                /// Adds a persistent buffer to the module.
                /// 
                /// This is typically used to register a buffer that should not to be
                /// considered a model parameter. For example, BatchNorm’s running_mean
                /// is not a parameter, but is part of the persistent state.
                /// 
                /// Buffers can be accessed as attributes using given names.
                /// </summary>
                /// <param name="name">
                /// name of the buffer. The buffer can be accessed
                /// from this module using the given name
                /// </param>
                /// <param name="tensor">
                /// buffer to be registered.
                /// </param>
                public void register_buffer(string name, Tensor tensor)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                        name,
                        tensor,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("register_buffer", pyargs, kwargs);
                }
                
                /// <summary>
                /// Registers a forward hook on the module.
                /// 
                /// The hook will be called every time after forward() has computed an output.
                /// It should have the following signature:
                /// 
                /// hook(module, input, output) -&gt; None
                /// 
                /// The hook should not modify the input or output.
                /// </summary>
                public utils.hooks.RemovableHandle register_forward_hook(Action<Module, Tensor[], Tensor[]> hook)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                        hook,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("register_forward_hook", pyargs, kwargs);
                    return ToCsharp<utils.hooks.RemovableHandle>(py);
                }
                
                /// <summary>
                /// Registers a forward pre-hook on the module.
                /// 
                /// The hook will be called every time before forward() is invoked.
                /// It should have the following signature:
                /// 
                /// hook(module, input) -&gt; None
                /// 
                /// The hook should not modify the input.
                /// </summary>
                public utils.hooks.RemovableHandle register_forward_pre_hook(Action<Module, Tensor[]> hook)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                        hook,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("register_forward_pre_hook", pyargs, kwargs);
                    return ToCsharp<utils.hooks.RemovableHandle>(py);
                }
                
                /// <summary>
                /// Adds a parameter to the module.
                /// 
                /// The parameter can be accessed as an attribute using given name.
                /// </summary>
                /// <param name="name">
                /// name of the parameter. The parameter can be accessed
                /// from this module using the given name
                /// </param>
                /// <param name="param">
                /// parameter to be added to the module.
                /// </param>
                public void register_parameter(string name, Parameter param)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                        name,
                        param,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("register_parameter", pyargs, kwargs);
                }
                
                /// <summary>
                /// Returns a dictionary containing a whole state of the module.
                /// 
                /// Both parameters and persistent buffers (e.g. running averages) are
                /// included. Keys are corresponding parameter and buffer names.
                /// </summary>
                public Hashtable state_dict(Hashtable destination = null, string prefix = "", bool keep_vars = false)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                    });
                    var kwargs=new PyDict();
                    if (destination!=null) kwargs["destination"]=ToPython(destination);
                    if (prefix!="") kwargs["prefix"]=ToPython(prefix);
                    if (keep_vars!=false) kwargs["keep_vars"]=ToPython(keep_vars);
                    dynamic py = __self__.InvokeMethod("state_dict", pyargs, kwargs);
                    return ToCsharp<Hashtable>(py);
                }
                
                public Module to(Device device, Dtype dtype, bool non_blocking = false)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                        device,
                        dtype,
                    });
                    var kwargs=new PyDict();
                    if (non_blocking!=false) kwargs["non_blocking"]=ToPython(non_blocking);
                    dynamic py = __self__.InvokeMethod("to", pyargs, kwargs);
                    return ToCsharp<Module>(py);
                }
                
                public Module to(Dtype dtype, bool non_blocking = false)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                        dtype,
                    });
                    var kwargs=new PyDict();
                    if (non_blocking!=false) kwargs["non_blocking"]=ToPython(non_blocking);
                    dynamic py = __self__.InvokeMethod("to", pyargs, kwargs);
                    return ToCsharp<Module>(py);
                }
                
                public Module to(Tensor tensor, bool non_blocking = false)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                        tensor,
                    });
                    var kwargs=new PyDict();
                    if (non_blocking!=false) kwargs["non_blocking"]=ToPython(non_blocking);
                    dynamic py = __self__.InvokeMethod("to", pyargs, kwargs);
                    return ToCsharp<Module>(py);
                }
                
                /// <summary>
                /// Sets the module in training mode.
                /// 
                /// This has any effect only on certain modules. See documentations of
                /// particular modules for details of their behaviors in training/evaluation
                /// mode, if they are affected, e.g. Dropout, BatchNorm,
                /// etc.
                /// </summary>
                public Module train(bool mode = true)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                    });
                    var kwargs=new PyDict();
                    if (mode!=true) kwargs["mode"]=ToPython(mode);
                    dynamic py = __self__.InvokeMethod("train", pyargs, kwargs);
                    return ToCsharp<Module>(py);
                }
                
                /// <summary>
                /// Casts all parameters and buffers to dst_type.
                /// </summary>
                public Module type(Dtype dst_type)
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    var pyargs=ToTuple(new object[]
                    {
                        dst_type,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("type", pyargs, kwargs);
                    return ToCsharp<Module>(py);
                }
                
                /// <summary>
                /// Sets gradients of all model parameters to zero.
                /// </summary>
                public void zero_grad()
                {
                    //auto-generated code, do not change
                    var __self__=self;
                    dynamic py = __self__.InvokeMethod("zero_grad");
                }
                
            }
        }
    }
    
}
