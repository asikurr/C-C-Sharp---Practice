using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceExample
{
    internal class Bus : ITransport
    {
        public void Move()
        {
            throw new NotImplementedException();
        }

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }
    }
}
