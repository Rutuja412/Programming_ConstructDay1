using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    internal class SumOf5
    {    
        public static void SumofFirstfive()
        {
            int Sum = 0;
            int i = 1;
            while(i<=5)
            {
                Sum=Sum+i;
                i++;
                Console.Write(" {0} ", i);
            }
            Console.WriteLine("\nSum Of First 5 Numbers = " + Sum);
        }
    }
}
