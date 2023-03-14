using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    internal class ArithmaticOperation
    {
        public static void Calculator()
        {
            Console.WriteLine("Enter First Number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Select Correct Option");
            Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division\n5.Exit");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Additiom : " + (x + y));
                    break;
                    case 2:
                    Console.WriteLine("Substraction :" + (x - y));
                    break; 
                case 3:
                    Console.WriteLine("Multiplication : " + (x * y));
                    break;
                    case 4:
                    Console.WriteLine("Division : " + (x / y));
                    break;
                    default:
                    Console.WriteLine("Enter Correct Option");
                    break;


            }
        }
    }
}
