using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    internal class Voter
    {
        public static void CheckVoter()
        {
            Console.WriteLine("Enter age ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18 && age <= 60)
            {
                Console.WriteLine("You are eligible for voting");

            }
            else if (age < 18)
            {
                Console.WriteLine("You are below 18--- not eligible");
            }
            else
            {
                Console.WriteLine("You are above 60 stay home stay safe !!");
            }
        }
    }
}
