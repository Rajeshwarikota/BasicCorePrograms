using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Core Programs");
            Console.WriteLine("\n1:HeadAndTail\n2:LeapYear\n3:PowerOfTwo\n4.HarmonicNumber\n5.ReaminderandQuotient\n11:Exit");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    HeadAndTail.HeadandTailPercentage();
                    break;
                case 2:
                    LeapYear.LeapYearCheck();
                    break;
                case 3:
                    PowerOfTwo.PowerTwo();
                    break;
                case 4:
                    HarmonicNumber.HarmonicValue();
                    break;
                case 5:
                    RemainderandQuotient.Divmethod();
                    break;
                default:
                    Console.WriteLine("choose the above options");
                    break;
            }
            Console.ReadLine();
        }

    }
}
