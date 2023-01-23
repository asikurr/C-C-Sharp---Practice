using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractics
{
    internal class Swap
    {
        public void swap()
        {
            Console.WriteLine("Give First Number!");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Give Second Number!");
            int num2 = Int32.Parse(Console.ReadLine());
            (num1, num2) = (num2, num1);
            Console.WriteLine("Now swap in number 1 is " + num1);
            Console.WriteLine("Now swap in number 2 is " + num2);
        }

        public void swapwithtemp()
        {
            int number1, number2, temp;
            Console.WriteLine("Give First Number for swap");
             number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Give Second Number for swap");
             number2 = Int32.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
    
            Console.WriteLine("Now swap in number 1 is " + number1);
            Console.WriteLine("Now swap in number 2 is " + number2);
        }

        public void swapwith()
        {
            int number1, number2;
            Console.WriteLine("Give First Number for swap");
            number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Give Second Number for swap");
            number2 = Int32.Parse(Console.ReadLine());
            number1 = number1 + number2;
            number2 = number1 - number2;

            number1=  number1 - number2;

            Console.WriteLine("Now swap in number 1 is " + number1);
            Console.WriteLine("Now swap in number 2 is " + number2);
        }
    }
}
