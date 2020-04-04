using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexOF
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the location of a string within another string
            //use the method .IndexOf()

            //pseudo code (statements)

            // need a original string
            //declare any variables
            //do
            //get string to look for (method: GetString())
            //find query string in original string
            //test if found
            //     no: not found msg
            //    yes: display index where found in original string
            //while not to stop

            string myString = "CPSC1012 Fundmental Programing";
            int startpos = 0;
            string inputString = "";
            int indexat = 0;
            do
            {
                inputString = GetString();
                //findinstring.IndexOf(querystring, start index position)
                //if the querystring is found in findinstring the result will be an index of 0 or more
                //    only the FIRST occurance of the querystring has the index returned, dependent on the start location
                //if the querystring is NOT found in findinstring the result is -1
                //IndexOf is case sensitive, use StringComparison.OrdinalIgnoreCase to avoid case sensitivity
                indexat = myString.IndexOf(inputString, startpos, StringComparison.OrdinalIgnoreCase);
                //indexat = myString.ToUpper().IndexOf(inputString.ToUpper(), startpos);
                if (!inputString.Equals("-1")) //test to see if i quit
                {
                    if (indexat < 0)
                    {
                        Console.WriteLine($"{inputString} not found in {myString}");
                    }
                    else
                    {
                        Console.WriteLine($"{inputString} found in {myString} at index {indexat}");
                    }
                }
            } while (!inputString.Equals("-1"));
            Console.ReadKey();
        }

        static string GetString()

        {
            Console.Write("Enter query string\t");
            string input = Console.ReadLine();
            return input;
        }
    }
}
