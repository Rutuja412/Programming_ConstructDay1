using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    internal class PowerOfTwo
    {
        public static void FindPowerOfTwo()
        {
            Console.WriteLine("Please Enter number until you want find power");
           int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                int power = (int)Math.Pow(2, i);
                Console.WriteLine("2^{0} = {1}", i,power); 
            }
        }
    }
}
