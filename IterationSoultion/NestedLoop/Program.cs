using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //query user for a number
            //validate a number was entered (integer)
            //if a number was entered check for even/odd
            //continue unless a 0 was entered then exit

            //to validate a string to contain an number
            //   use the xxxx.TryParse of the number datatype
            // syntax of .TryParse(string, out variablename)
            // string hold the value to test
            // if the value in good:
            //      the number is automatically place in your variable
            //      the test returns a boolean true
            // if the value is NOT good:
            //      NO value is placed in your variable
            //      the test returns a boolean false

            int number = -1;
            string inputString = "";
           
            while (number != 0)
            {
                //do
                //{
                //    Console.Write("Enter a positive whole number OR enter 0 to quit.");
                //    inputString = Console.ReadLine();
                //} while (!int.TryParse(inputString, out number));
                
                //condition flag
                //NOTE: it MUST be reset on EACH pass of the OUTER loop
                bool validFlag = false;  
                do
                {
                    Console.Write("Enter a positive whole number OR enter 0 to quit.");
                    inputString = Console.ReadLine();
                    //need a test to appropriately set your loop exit test
                    if (int.TryParse(inputString, out number))
                    {
                        //set the flag to an appropriate value to work with your logic
                        validFlag = true;
                    }
                } while (validFlag == false);

                if (number>0)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"{number} is an even value.\n\n");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is an odd value.\n\n");
                    }
                }
                else
                {
                    if(number == 0)
                    {
                        Console.WriteLine($"thank you. come again.\n\n");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is invalid. try again.\n\n");
                    }
                }
            }//eol while
           
        }
    }
}
