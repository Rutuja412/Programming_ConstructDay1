using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    internal class OddEven
    {
        public static void CheckOddEven()
        {
            Console.WriteLine("Enter Number ");
            int number=Convert.ToInt32(Console.ReadLine());

            if (number % 2==0)
            {
                Console.WriteLine( number + " is Even Number");
            }
            else
            {
                Console.WriteLine(number + " is Odd Number");
            }
        }
    }
}
