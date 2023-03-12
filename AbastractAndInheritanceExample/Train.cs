using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastractAndInheritanceExample
{
    internal class Train : Transport
    {
        public override void StartEngine()
        {
            Console.WriteLine("Start Traain Engine.");
        }
    }
}
