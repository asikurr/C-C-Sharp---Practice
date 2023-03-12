using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractAndInheritanceExample
{
    internal class Electronics : Product
    {
        public string Brand { get; set; }

        public Electronics(string title) : base(title)
        {
        }

    }
}
