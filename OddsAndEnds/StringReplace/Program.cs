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

            //.Replace(char, char) string method
            string myString = "CPSC1012 Fundmental Programing";
            string inputString = "";
            char oldchar;
            char newchar;
            string oldstring = "";
            string newstring = "";
            do
            {
                inputString = GetString("Get character/string you wish to replace");
                
                if (!inputString.Equals("-1")) //test to see if i quit
                {
                    Console.WriteLine($"your old string is {myString}");
                    oldstring = inputString;
                    inputString = GetString("Get new character/string you wish to use in replacement");
                    newstring = inputString;
                    //.Replace() will replace any occurance of the old character with the replacement char
                    //.Replace() returns its work as a string
                    //you need to receive the string on an assignment statement
                    myString = myString.Replace(oldstring, newstring);
                    Console.WriteLine($"your new string is {myString}");
                }
            } while (!inputString.Equals("-1"));
            Console.ReadKey();
        }

        static string GetString(string prompt)

        {
            Console.Write($"{prompt}\t");
            string input = Console.ReadLine();
            return input;
        }
    }
}
