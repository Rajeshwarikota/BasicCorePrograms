using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class SwapTwoNumbers
    {
        public static void Swapping()
        {
            int temp,number 1,number 2;

            Console.WriteLine("Enter the first number");
            int number1 = Convert.ToInt(Console.ReadLine);
            Console.WriteLine("Enter the second number");
            int number2 = Convert.ToInt(Console.ReadLine);

            Console.WriteLine("Before Swapping");

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("After Swapping");

            Console.WriteLine("first number is:"+ number1);
            Console.WriteLine("second number is:"+ number2);
        }
    }
}
