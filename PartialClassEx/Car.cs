using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassEx
{
    internal partial class Car
    {
        private string Model { get; set; }

        public Car(string model)
        {
            Model= model;
        }
        public void StartCar()
        {
            Console.WriteLine("Car is Starting.");
        }
    }
}
