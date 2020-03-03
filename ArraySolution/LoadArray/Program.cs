using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //arrays are a fixed sixe collection of a single datatype
            //array names hold an internal address to the actual physical
            //   memory location of the array storage area
            //a single item in the array is called the array element

            //declaring an array requires knowing the
            //  a) physical size
            //  b) the elements to initialize the array

            //a) array declared by phyiscal size
            int[] physicallyDeclared = new int[7];

            //b) the elements to initialize the array
            //   the number of values specifies the phyiscal array size
            //   each supplied value is place within the array consecutively
            //   the datatype after the new is optional BUT the values given
            //       MUST match the receiving array declaration datatype.
            int[] diceValue = new [] { 11, 2, 333, 44, 5, 56 };

            //the physically declared array has an initial default
            //   value for each element depending on the system default 
            //   value of the array datatype
            int pDSize = physicallyDeclared.Length;
            for (int index = 0; index < pDSize; index++)
            {
                Console.WriteLine($"physicallyDeclared array element {index + 1} located at index {index} has a value of {physicallyDeclared[index]}");
            }
            int dVSize = diceValue.Length;
            for (int index = 0; index < dVSize; index++)
            {
                Console.WriteLine($"diceValue array element {index + 1} located at index {index} has a value of {diceValue[index]}");
            }
            Console.ReadKey();
        }
    }
}
