using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractAndInheritanceExample
{
    abstract class Transport
    {
        public string Speed { get; set; }
        public abstract void StartEngine();
    }
}
