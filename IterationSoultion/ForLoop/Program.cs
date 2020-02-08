using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample of pre-test loops
            //while loop
            //for loop

            //code a while loop that breaks the components of 
            //    a for loop into visible individual items
            //counter: this will count the number of times
            //         through the loop
            //while condition: counter is less than my stop value
            //   (stop value is either an upper limit or lower limit)

            //go through the loop 7 times
            //count the number of even numbers, number of odd numbers
            //after the loop print out the even and odd number running totals
            int evenNumbers = 0;
            int oddNumbers = 0;
            string inputValue;
            int number;
            const int TWO = 2;

            int loopCounter = 1;
            while (loopCounter <= 7)
            {
                Console.Write("Enter a number:\t");
                inputValue = Console.ReadLine();
                number = int.Parse(inputValue);

                if ((number % TWO) == 0)
                {
                    //evenNumbers = evenNumbers + 1;
                    evenNumbers++;      //running total
                }
                else
                {
                    //oddNumbers = oddNumbers + 1;
                    oddNumbers += 1;    //running total
                }//eof

                //increment the loop counter
                loopCounter++;
            }//eol  end of loop

            Console.WriteLine($"\nYour even number count is {evenNumbers}");
            Console.WriteLine($"Your odd number count is {oddNumbers}\n\n");


            //for loop
            //the for loop is a pre-test loop structure
            evenNumbers = 0;    //reset totals
            oddNumbers = 0;     //reset totals
            int endPoint = 7;   //Sentinal value
            for (int forCounter = 1; forCounter <= endPoint; forCounter++)
            {
                Console.Write("Enter a number:\t");
                inputValue = Console.ReadLine();
                number = int.Parse(inputValue);

                if ((number % TWO) == 0)
                {
                    //evenNumbers = evenNumbers + 1;
                    evenNumbers++;      //running total
                }
                else
                {
                    //oddNumbers = oddNumbers + 1;
                    oddNumbers += 1;    //running total
                }//eof
            }//eol end of loop

            Console.WriteLine($"\nYour even number count is {evenNumbers}");
            Console.WriteLine($"Your odd number count is {oddNumbers}\n\n");

        
        }
    }
}
