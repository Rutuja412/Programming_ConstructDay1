using System;

namespace ProgrammingConstruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Problems");
            Console.WriteLine("Select given options");
            Console.WriteLine("1.CheckEqua;ity\n2.OddEven\n3.Voting\n4.Large Number\n5.Eligibility For Admission\n6.DayWeek\n7.Arithmatic Operation\n8.Power Of 2 \n9. Sum Of Sqaure \n10Factorial\n11.Exit ");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Check Equality of numbers");
                    Equality.CheckEquality();
                    break;
                    case 2:
                    Console.WriteLine("OddEven");
                    break; 
                case 3:
                    Console.WriteLine("Check Age agg Voter");
                    Voter.CheckVoter();
                    break;
                    case 4:
                    Console.WriteLine("Largest number");
                    LargestNumber.MaximumIntegerNumber(1, 3, 5);
                    break;
                    case 5:
                    Console.WriteLine("Check Eligibility of Marks");
                    AdmissionEligibility.CheckEligibility();
                    break;
                    case 6:
                    Console.WriteLine("WeekDays");
                    WeekDays.Week();
                    break; 
                case 7:
                    Console.WriteLine("Arithmatic Operation");
                    ArithmaticOperation.Calculator();
                    break;
                    case 8:
                    Console.WriteLine("Power of two");
                    PowerOfTwo.FindPowerOfTwo();
                    break;
                    case 9:
                    Console.WriteLine("Sum Of Squares of given number");
                    SquareOfSum.CalculateSumofSquares();
                    break;
                    case 10:
                    Console.WriteLine("Factorial");
                    Factorial.FindFactorial();
                    break;
                    default: Console.WriteLine("Enter Correct Number");
                    break;

            }
        }
    }
}
