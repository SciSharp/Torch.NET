using System;
using System.Collections.Generic;
using System.Text;

namespace Torch.CodeGenerator.Generators
{
    
    public class TemplateAttribute : Attribute
    {
        public string ApiFunction { get; set; }

        public TemplateAttribute(string api_function)
        {
            ApiFunction = api_function;
        }
    }

}
