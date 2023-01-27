using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwappingTwoNumbers
    {
        public static void Swapping()
        {
            int temp ;

            Console.WriteLine("Enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Before Swapping");

            Console.WriteLine("first number is:" + number1);
            Console.WriteLine("second number is:" + number2);

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("After Swapping");

            Console.WriteLine("first number is:" + number1);
            Console.WriteLine("second number is:" + number2);
        }
    }
}
