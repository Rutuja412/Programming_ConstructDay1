using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    internal class Equality
    {
        public static void CheckEquality()
        {
            Console.WriteLine("Enter first number");
            int FirstNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int SecondNumber=Convert.ToInt32(Console.ReadLine());
            if (FirstNumber==SecondNumber)
            {
                Console.WriteLine("First Number is Equal to Second Number");
            }
            else
            {
                Console.WriteLine("Numbers are not Equal");
            }
        }
    }
}
