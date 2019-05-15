using System;
using System.Collections.Generic;

namespace Torch.CodeGenerator.Models
{
    public class Declaration
    {
        public string name { get; set; }
        public bool matches_jit_signature { get; set; }
        public string schema_string { get; set; }
        public string method_prefix_derived { get; set; }
        public List<Argument> arguments { get; set; }
        public List<string> method_of { get; set; }
        public string mode { get; set; }
        public string python_module { get; set; }
        public List<Argument> returns { get; set; }
        public bool is_factory_method { get; set; }
        public bool @abstract { get; set; }
        public bool requires_tensor { get; set; }
        public bool device_guard { get; set; }
        public bool with_gil { get; set; }
        public bool deprecated { get; set; }
        public bool inplace { get; set; }
    }
}
