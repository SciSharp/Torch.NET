using System;
using System.Collections.Generic;
using System.Text;

namespace Torch.CodeGenerator
{
    interface ICodeGenerator
    {
        string Generate();

        Dictionary<string, string> LoadDocs();
    }
}
