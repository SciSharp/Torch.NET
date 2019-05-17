using System;
using System.Collections.Generic;
using System.Text;
using CodeMinion.Core.Attributes;

namespace Torch.CodeGenerator.Generators.Templates
{
    [PartialClassTemplate("Tensor<T>", "GetData<T>")]
    public class TensorMembersGenerator
    {
    }
}
