using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1
            //Write a program that will prompt for a number and
            //display "positive" if it is greater than zero,
            //"Negative" if it is less than zero, and zero if it
            //is equal to zero
            Console.WriteLine($"Question 1\n");
            int numArg = -1;
            if (numArg == 0)
            {
                Console.WriteLine($"The number {numArg} is zero");
            }
            else
            {
                if (numArg > 0)
                {
                    Console.WriteLine($"The number {numArg} is positive");
                }
                else
                {
                    Console.WriteLine($"The number {numArg} is negative");
                }
            }
            Console.WriteLine("\n\n");
            //Question 2
            //Write a program that will determine the cost of admission 
            //for a theatre. The price of admission is based on the age 
            //of the customer.Your program should prompt the user for 
            //their age and then display the correct admission amount.
            Console.WriteLine($"Question 2\n");
            int Age = 13;
            if (Age < 7)
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Child FREE $0.00");
            }
            else if (Age < 18)
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Student $9.80");
            }
            else if (Age < 55)
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Adult $11.35");
            }
            else
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Senior $10.00");
            }

            if (Age > 54)
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Senior $10.00");
            }
            else if (Age > 17)
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Adult $11.35");
            }
            else if (Age > 6)
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Student $9.80");
            }
            else
            {
                Console.WriteLine($"Your age of {Age} has an admission fee of : Child FREE $0.00");
            }
            Console.WriteLine("\n\n");
            //Question 3
            //Write a program that will prompt the user for a student’s 
            //name and their mark.The program should display the student’s
            //name along with a letter grade calculated using the 
            //following table:            // 100-90 A; 89-80 B; 79-70 C; 69-50 D; 49-0 F;


            //Question 4
        }
    }
}
