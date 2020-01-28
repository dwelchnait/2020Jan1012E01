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
                string codeblock2T = "level 2T coding block";
                high = num2; //new highest num
                if (num3 > high)
                {
                    string codeblock3T = "level 3T coding block";
                    high = num3;
                    mid = num2;
                    low = num1;
                    Console.WriteLine(codeblock3T);
                    Console.WriteLine(codeblock2T);
                    
                    //outside the current code block OR parent code block
                    //Console.WriteLine(codeblock4T); 
                }// goes to WriteLine at end of nested if
                else
                {
                    string codeblock3F = "level 3F coding block";
                    if (num3 > num1)
                    {
                        string codeblock4T = "level 4T coding block";
                        mid = num3;
                        low = num1;

                        //codeblock4T was declared within this code block
                        //codeblock4T is deemed "alive"
                        //the existance of codeblock4T (or any variable) is
                        //   called "variable scope"
                        Console.WriteLine(codeblock4T);
                        //codeblock4T dies at the end of its code block
                    }// goes to WriteLine at end of nested if
                    else
                    {
                        string codeblock4F = "level 4F coding block";
                        mid = num1;
                        low = num3;
                        Console.WriteLine(codeblock2T);
                    }//goes to WriteLine at end of nested if

                    //codeblock4T dies on line 47 at the end of its code block
                    //Console.WriteLine(codeblock4T);
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
