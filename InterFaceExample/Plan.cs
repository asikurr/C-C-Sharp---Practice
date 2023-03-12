using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceExample
{
    internal class Plan : ITransport, IFlyable
    {
        public void FlyPlan()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void StartEngine()
        {
            Console.WriteLine("This is from Plan Start Engine.");
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }
    }
}
