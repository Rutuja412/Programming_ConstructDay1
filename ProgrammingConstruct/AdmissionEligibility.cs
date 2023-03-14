using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    internal class AdmissionEligibility
    {
        public static void  CheckEligibility()
        {
            Console.WriteLine("Marks in Maths >=65");
            Console.WriteLine("Marks in Physics >= 55");
            Console.WriteLine("Marks in Chemistry >=50");
            Console.WriteLine("Total in All 3 subjects >=180");
            Console.WriteLine("Total in Math and Subjects>=140");
            Console.WriteLine("Enter marks for Physics : ");
            int Physics=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks for Chemistry : ");
            int Chemistry=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks for Maths : ");
            int Maths=Convert.ToInt32(Console.ReadLine());
            if (Maths >= 65 && Physics >= 55 && Chemistry >= 50 && (Maths + Physics + Chemistry) >= 180)
                Console.WriteLine("The candidate is eligible for admission\n");
            else if (Maths + Physics >= 140)
                Console.WriteLine("The candidate is eligible for admission\n");
            else
                Console.WriteLine("The candidate is not eligible for admission\n");
        }
    }
}
