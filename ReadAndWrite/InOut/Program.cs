using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * implement a temperature converter from Celsius to Fahrenheit
             * 
             * Jan 15 2020
             */

            //input : Celsius temperature 
            //         string inputTemp
            //         double theCelsiusTemperature

            //output: Fahrenheit temperature
            //         double theFahrenheitTemperature

            //expression:  (ct * 9/5) + 32 
            //check with ct = 0 expect ft =32
            //check with ct = -40 expect ft = -40
            //check with ct = 100 expect ft = 212

            //prompt for a temperature
            // .Write keeps your cursor on the same line
            Console.Write("enter a Celsius temperature:\t");

            //to obtain the key strokes that the user types (input)
            //   use .ReadLine()
            //data comes into the program as a string

            string inputTemp = Console.ReadLine();

            //convert the string to a double
            //to do this, you will using parsing
            //  syntax:   datatypeTo.Parse(string)
            double theCelsiusTemperature = double.Parse(inputTemp);

            //calculation using the conversion expersion
            double theFahrenheitTemperature = (theCelsiusTemperature * (9.0d / 5.0d)) + 32.0d;

            //output
            //.WriteLine() automaticaly goes to the next line.
            Console.WriteLine($"The Celsius temperature of {theCelsiusTemperature} in " +
                $" Fahrenheit is {theFahrenheitTemperature}");

            //to ensure that your display stays whether you run without debugging (Ctrl + F5)
            //or running with debugging (F5 or the Start button at the top)
            //add a .ReadLine()
            Console.ReadLine();

        }
    }
}
