using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    internal class FlipCoin
    {
        public static void FlipcoinSimulation()
        {
            Random random = new Random();
            int Heads = 0;
            int Tails = 0;

            while (Heads < 20 && Tails < 20)
            {
                int option = random.Next(2);
                if (option == 0)
                {
                  Console.WriteLine("Heads");
                    Heads++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    Tails++;
                }
            }
            Console.WriteLine("number of Heads : {0}", Heads);
            Console.WriteLine("number of Tails  :{0}", Tails);
            if (Heads == 20)
            {
                Console.WriteLine("Heads wins!");
            }
            else
            {
                Console.WriteLine("Tails wins!");
            }
        }
    }
}

            
