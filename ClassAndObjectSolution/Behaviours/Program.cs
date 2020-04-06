using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaviours
{
    class Program
    {
        static void Main(string[] args)
        {
            Opening[] myOpenings = new Opening[10];
            Opening theInstance = null;
            int logicalsize = 0;
            try
            {
                theInstance = new Opening(); //default constructor
                theInstance.Name = "2 pane gas filled";
                myOpenings[logicalsize] = theInstance;
                logicalsize++;

                theInstance = new Opening("single pane plexi-glass", 2.1, 1.0); //greedie constructor
                myOpenings[logicalsize] = theInstance;
                logicalsize++;

                theInstance = new Opening(); //default constructor
                theInstance.Name = "2 pane tinted";
                theInstance.Height = 1.75;
                theInstance.Width = 3.2;
                myOpenings[logicalsize] = theInstance;
                logicalsize++;

                //display the instances of the array
                for (int i = 0; i < logicalsize; i++)
                {
                    Console.WriteLine(myOpenings[i].ToString());

                    //play with the class behaviours
                    Console.WriteLine("\n\n Behaviours\n");
                    Console.WriteLine($"Area: {myOpenings[i].Area()}");
                    Console.WriteLine($"Perimeter: {myOpenings[i].Perimeter()}");
                    Console.WriteLine($"Estimate: {myOpenings[i].Estimate(14.95,2)}\n\n");
                    
                }

                theInstance = new Opening(); //bad width, looking for an exception
                theInstance.Name = "bad width";
                theInstance.Height = 1.75;
                theInstance.Width = -3.2;  //error
                myOpenings[logicalsize] = theInstance;
                logicalsize++;
                Console.WriteLine(myOpenings[logicalsize - 1].ToString());

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
