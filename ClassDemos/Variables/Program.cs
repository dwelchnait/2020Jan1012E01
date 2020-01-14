using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // is a single line comment
        /* is a block 
          line
          comment
          group */
        //C# is a "strongly typed" language
        //    character types: string(""); char('')
        //    whole numerical types: integer and many others
        //    floating numerical types: decimal(28 - 29), double(15 - 16), float(7)
        //    logical type: boolean

        //declare variables within Main
        //general grammar (syntax) for declaring a variable is:
        //     accesstype datatype variablename [= value];
        // special case: within a static class the accesstype is not required
        //by default numerical variable are set to 0
        decimal myWeight;
        decimal myHeight;
        decimal BMI = 0.0m;

        //constant unchanging values are declared using the const syntax
        //you CANNOT change of the value of a const variable.
        const decimal ImperialBMIValue = 703.0m;

            //assign a value to a value
            //this statement is referred to as an "Assignment" statement
            //data moves from rigth to left on an assigment statement
            //on the left side of the = sign will be the receiving storage area
            //on the right side of the = sign will be the data you wish to store

            //numerical numbers need to match the variable datatype
            //integers have no decimal places
            //doubles are the default but may explicitly be type using a d
            //decimals require to be explicitly typed using a m
            myWeight = 110.0m;
            myHeight = 1.75m;

            //math calculations following the acceptable rules of arithmetic
            //  - assignment
            // () execute within
            //  * / %j
            // + -
            BMI = myWeight / (myHeight * myHeight);
            Console.WriteLine("According to your metric weight of {0:0.0} and height of {1:0.00}: your BMI is {2:0.0}", myWeight, myHeight, BMI);

            //Imperial calculation
            myWeight = 242.5m;
            myHeight = 69.0m;
            BMI = (myWeight * ImperialBMIValue) / (myHeight * myHeight);
            Console.WriteLine($"According to your imperial weight of {myWeight:0.0} and height of {myHeight:0.00}: your BMI is {BMI:0.0}");
        }
    }
}
