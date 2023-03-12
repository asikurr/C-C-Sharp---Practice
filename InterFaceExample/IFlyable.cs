using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceExample
{
    internal interface IFlyable
    {
        void FlyPlan();

        void Land()
        {
            Console.WriteLine("plane Landing.");
        }
    }
}
