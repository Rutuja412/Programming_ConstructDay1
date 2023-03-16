using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingConstruct
{
    internal class ReverseString
    {
        public static void ReverseWord()
        {
            Console.WriteLine("Enter word which you want to reverse");
            string word=Console.ReadLine();
            Console.WriteLine(word);
            Char[]array= word.ToCharArray();
            int i= word.Length - 1;
            while(i >= 0)
            {
                Console.WriteLine(array[i]);
                i--;
            }
        }
        
    }
}
