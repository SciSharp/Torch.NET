using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Torch.CodeGenerator.Generators;
using Torch.CodeGenerator.Models;

namespace Torch.CodeGenerator
{

    public abstract class GeneratorTemplate
    {
        public abstract void GenerateBody(Declaration decl, StringBuilder s);
    }

    [Template("tensor")]
    internal class CreateTensor : GeneratorTemplate
    {
        public override void GenerateBody(Declaration decl, StringBuilder s)
        {
            var arg_type = decl.arguments[0].type;
            switch (arg_type) {
                case "byte[]":
                case "int[]":
                case "long[]":
                case "float[]":
                case "double[]":
                    Generate1DArray(arg_type, decl, s);
                    return;
            }
            s.AppendLine(
                $"    throw new NotImplementedException(\"This data type is not yet implemented: {arg_type}\");");
            return;
        }

        private static void Generate1DArray(string arg_type, Declaration decl, StringBuilder s)
        {           
            var dtype_map = new Hashtable
            {
                ["byte[]"] = "UInt8",
                ["int[]"] = "Int32",
                ["long[]"] = "Int64",
                ["float[]"] = "Float32",
                ["double[]"] = "Float64",
            };
            var dtype = dtype_map[arg_type];
            if (dtype == null) {
                s.AppendLine(
                    $"    throw new NotImplementedException(\"This data type is not yet implemented: {arg_type}\");");
                return;
            }
            s.AppendLine($"    // note: this implementation works only for device CPU");
            s.AppendLine($"    // todo: implement for GPU");
            s.AppendLine($"    var tensor = empty(new Shape(data.Length), dtype: Torch.dtype.{dtype}, device: device,");
            s.AppendLine($"        requires_grad: requires_grad, pin_memory: pin_memory);");
            s.AppendLine($"    var storage = tensor.PyObject.storage();");
            s.AppendLine($"    long ptr = storage.data_ptr();");
            s.AppendLine($"    Marshal.Copy(data, 0, new IntPtr(ptr), data.Length);");
            s.AppendLine($"    return tensor;");
        }
    }


}
