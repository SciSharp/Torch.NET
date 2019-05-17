using System;
using System.Collections.Generic;
using System.Text;
using Torch.CodeGenerator.Models;

namespace Torch.CodeGenerator
{

    public abstract class GeneratorTemplate
    {
        public abstract void GenerateBody(Declaration decl, StringBuilder s);
    }
}
