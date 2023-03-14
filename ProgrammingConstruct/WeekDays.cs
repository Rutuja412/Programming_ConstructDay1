using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    internal class WeekDays
    {
        public static void Week()
        {
            Console.WriteLine("Enter number");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesaday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine(" Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine(" Saturday");
                    break;
                case 7:
                    Console.WriteLine(" Sunday");
                    break;
                default:
                    Console.WriteLine(" Enter correct number");
                    break;

            }
        }
    }
}
