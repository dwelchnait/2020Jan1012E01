using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "CPSC1012 Fundamental Programing";
            int start = 1;
            
            string letter = "";
            int at = 0;
            do
            {
                Console.Write("Enter a letter\t");
                letter = Console.ReadLine();
                at = myString.IndexOf(letter, start);
                if (!letter.Equals("-1"))
                {
                    if (at == -1)
                    {
                        Console.WriteLine($"letter {letter} not in {myString}");
                    }
                    else
                    {
                        Console.WriteLine($"letter {letter} found at index {at} in {myString}");
                    }
                }
            } while (!letter.Equals("-1"));
            Console.ReadKey();
        }
    }
}
