using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeRefTypeExample
{
    internal struct Person
    {
        public string Name { get; set; }
        public uint Age { get; set; }
        public Child Child { get; set; }
    }
}
