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

    public class PartialClassTemplateAttribute : Attribute
    {
        public string ClassName { get; set; }
        public string MemberName { get; set; }

        public PartialClassTemplateAttribute(string class_name, string member_name)
        {
            ClassName = class_name;
            MemberName = member_name;
        }
    }
}
