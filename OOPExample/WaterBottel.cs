using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class WaterBottel
    {
        public double WaterAmount;
        public string Color { get; set; }
        private double _capacity;
            public double Capacity {
            get
            {
                if (_capacity < 18)
                {
                    return 18;
                }
                else
                {
                    return _capacity;
                }

            }
            set {

                if (_capacity > 10)
                {
                    _capacity =  40;
                }
                else
                {
                    _capacity = value;
                }
            } 
        }

        public WaterBottel()
        {
            Capacity= 10;
            Color = "Green";
        }
        public WaterBottel(double capacity, string color) {
            Capacity = capacity;
            Color = color;
        }
        public void AddWather(int Amount)
        {
            WaterAmount += Amount;
        }
    
    }
}
