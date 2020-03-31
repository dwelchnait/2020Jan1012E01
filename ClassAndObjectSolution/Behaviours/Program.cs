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
            Window[] myWindows = new Window[10];
            Window theInstance = null;
            int logicalsize = 0;
            try
            {
                theInstance = new Window(); //default constructor
                theInstance.Model = "2 pane gas filled";
                myWindows[logicalsize] = theInstance;
                logicalsize++;

                theInstance = new Window("single pane plexi-glass", 2.1, 1.0); //greedie constructor
                myWindows[logicalsize] = theInstance;
                logicalsize++;

                theInstance = new Window(); //default constructor
                theInstance.Model = "2 pane tinted";
                theInstance.Height = 1.75;
                theInstance.Width = 3.2;
                myWindows[logicalsize] = theInstance;
                logicalsize++;

                //display the instances of the array
                for (int i = 0; i < logicalsize; i++)
                {
                    Console.WriteLine(myWindows[i].ToString());

                    //play with the class behaviours
                    Console.WriteLine("\n\n Behaviours\n");
                    Console.WriteLine($"Area: {myWindows[i].Area()}");
                    Console.WriteLine($"Perimeter: {myWindows[i].Perimeter()}");
                    Console.WriteLine($"Estimate: {myWindows[i].Estimate(14.95,2)}\n\n");
                    
                }

                theInstance = new Window(); //bad width, looking for an exception
                theInstance.Model = "bad width";
                theInstance.Height = 1.75;
                theInstance.Width = -3.2;  //error
                myWindows[logicalsize] = theInstance;
                logicalsize++;
                Console.WriteLine(myWindows[logicalsize - 1].ToString());

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
