using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIghMidLow
{
    class Program
    {
        static void Main(string[] args)
        {
            //so save time in the demo, the test values
            //   will be hard coded instead of prompt/read
            int num1 = 5;
            int num2 = 9;
            int num3 = 6;
            int high, mid, low;
            //assume one of the numbers is the highest
            high = num1;

            if (num2 > high)
            {
                high = num2; //new highest num
                if (num3 > high)
                {
                    high = num3;
                    mid = num2;
                    low = num1;
                }// goes to WriteLine at end of nested if
                else
                {
                    if (num3 > num1)
                    {
                        mid = num3;
                        low = num1;
                    }// goes to WriteLine at end of nested if
                    else
                    {
                        mid = num1;
                        low = num3;
                    }//goes to WriteLine at end of nested if
                }
            }
            else
            {
                if (num3 > high)
                {
                    high = num3;
                    mid = num1;
                    low = num2;
                }//goes to WriteLine at end of nested if
                else
                {
                    if (num3 > num2)
                    {
                        mid = num3;
                        low = num2;
                    }//goes to WriteLine at end of nested if
                    else
                    {
                        mid = num2;
                        low = num3;
                    }//goes to WriteLine at end of nested if
                }
            }//end of the nested if
            Console.WriteLine($"num1 {num1} num2 {num2} num3 {num3} order is high {high} mid {mid} low {low}");
            Console.ReadKey();
        }
    }
}
