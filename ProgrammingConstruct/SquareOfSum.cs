using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    internal class SquareOfSum
    {
        public static void CalculateSumofSquares()
        {
            Console.WriteLine("Enter a number until you want to find Sum of square");
            int n=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (i * i);
            }
            Console.WriteLine("Sum Of Squares is :" + sum);
        }
    }
}
