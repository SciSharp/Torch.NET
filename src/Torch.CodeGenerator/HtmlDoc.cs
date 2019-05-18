using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace Torch.ApiGenerator
{
    public class HtmlDoc
    {
        public string Filename { get; set; }
        //public string Url { get; set; }
        public string Text { get; set; }
        public HtmlDocument Doc { get; set; }
    }
}
