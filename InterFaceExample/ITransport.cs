using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceExample
{
    internal interface ITransport
    {
        public void StartEngine()
        {
            Console.WriteLine("This is from ITransportable Start Engine");
        }
        public void StopEngine();
        public void Move();

    }
}
