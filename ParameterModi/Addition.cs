using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModi
{
    internal class Addition
    {
        public int Sum(int a, int b)
        {
            return a+ b;
        }

        public int Sum(params int[] items)
        {
            int sum = 0;
            foreach (var item in items)
            {
                sum = sum + item;
            }
            return sum;
        }
        public void RefKeyWord(ref int x)
        {
            Console.WriteLine($"x value is {x}");
            x = 4;
        }
    }
}
