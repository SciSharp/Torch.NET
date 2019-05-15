namespace Torch.CodeGenerator
{
    public class Argument
    {
        public Annotation annotation { get; set; }
        public string dynamic_type { get; set; }
        public bool is_nullable { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string @default { get; set; }
        public bool kwarg_only { get; set; }
    }
}