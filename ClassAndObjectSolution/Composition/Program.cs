using Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Room House = new Room();
            bool finished = true;
            Console.Write("Identify the room such as bedroom, living room, kitchen, etc.\t");
            House.Name = Console.ReadLine();
            do
            {
                try
                {
                    GetWalls(House);
                    Console.Write("Another Wall (y,n)?\t");
                    finished = Console.ReadLine().ToLower().Equals("y") ? true : false;
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Data for wall is invalid. {ex.Message}");
                }

            } while (finished);
            finished = true;
            do
            {
                try
                {
                    GetOpenings(House);
                    Console.Write("Another opening (y,n)?\t");
                    finished = Console.ReadLine().ToLower().Equals("y") ? true : false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Data for wall is invalid. {ex.Message}");
                }
               
            } while (finished);

            double surfaceAreaTotal = 0.0;
            double openingAreaTotal = 0.0;
            Console.WriteLine("\n\nSummary of Room\n");
            Console.WriteLine($"Name: {House.Name}");
            Console.WriteLine("Walls:");
            for(int i = 0; i < House.Walls.Count; i++)
            {
                Console.WriteLine($"\tWall: {i + 1} Length: {House.Walls[i].Length} Height: {House.Walls[i].Height} " +
                    $"Surface Area: {House.Walls[i].Area()}");
                surfaceAreaTotal += House.Walls[i].Area();
            }
            Console.WriteLine($"\nTotal room surface area without openings: {surfaceAreaTotal}");
            Console.WriteLine("Openings:");

            foreach (var item in House.Openings)
            {
                Console.WriteLine($"\t {item.Name} Width: {item.Width} Height: {item.Height} " +
                   $"Opening Area: {item.Area()}");
                openingAreaTotal += item.Area();
            }
            Console.WriteLine($"\nTotal opening area: {openingAreaTotal}");

            Console.WriteLine($"\nTotal surface area of room requiring painting: {surfaceAreaTotal - openingAreaTotal}");
            Console.ReadKey();
        }

        static void GetWalls(Room House)
        {
            Wall theWall = new Wall();
            theWall.Length = GetValidInputNumber("Enter length of the wall:\t");
            theWall.Height = GetValidInputNumber("Enter height of the wall:\t");
            House.Walls.Add(theWall);
        }

        static void GetOpenings(Room House)
        {
            Opening theOpening = new Opening();
            Console.WriteLine("Identify the type of opening such as door or window\t");
            theOpening.Name = Console.ReadLine();
            theOpening.Width = GetValidInputNumber("Enter width of the opening:\t");
            theOpening.Height = GetValidInputNumber("Enter height of the openng:\t");
            House.Openings.Add(theOpening);
        }

        static double GetValidInputNumber(string prompt)
        {
            double number = 0.0;
            string input;
            bool good = false;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (!double.TryParse(input, out number))
                {
                    Console.WriteLine("Input value is not an acceptable number.");
                }
                else
                {
                    good = true;
                }
            } while (!good);
            return number;
        }
    }
}
