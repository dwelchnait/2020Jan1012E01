using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "CPSC1012 Fundamental Programing";
            string input = "";
            char old ;
            char replacement;
            do
            {
                Console.WriteLine($"current  string {myString}");
                Console.Write("Enter letters to go\t");
                input = Console.ReadLine();
                
                if (!input.Equals("-1"))
                {
                    old = char.Parse(input);
                    Console.Write("Enter replacement letters\t");
                    input = Console.ReadLine();
                    replacement = char.Parse(input);
                    myString = myString.Replace(old, replacement);
                    Console.WriteLine($"new string {myString}");
                }
            } while (!input.Equals("-1"));
           
        }

    }
}
