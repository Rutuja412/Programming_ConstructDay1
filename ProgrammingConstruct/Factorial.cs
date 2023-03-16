using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    public class Factorial
    {
        public static void FindFactorial()
        {
            int i, fact = 1;
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }
        
    }
}
