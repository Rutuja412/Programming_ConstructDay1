using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    internal class LargestNumber
    {
        public static void MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                Console.WriteLine(firstValue + " is greater");
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {

                Console.WriteLine(secondValue + " is greater");
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {

                Console.WriteLine(thirdValue + "is greater");
            }
        }
    }

}

