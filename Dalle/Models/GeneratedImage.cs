using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalle.Models
{
    public class GeneratedImage
    {
        public string ImagePath { get; set; }
        public string MainKeyWord { get; set; }
        public List<string> Keywords { get; set; }
    }
}
