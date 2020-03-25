using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 dimensional array (rows, columns)
            int[,] arr2D = new int[5, 3];

            //accessing a cell in your array requires you to specify 2 indexes, a rowindex and a colindex
            //syntax   arrayname[rowindex, colindex]
            for(int r = 0; r < 5; r++)
            {
                arr2D[r, 0] = 1;
            }

            for (int r = 0; r < 5; r++)
            {
                arr2D[r, 1] = r;
            }

            for(int r = 0; r < 5; r++)
            {
                arr2D[r, 2] = arr2D[r, 0] + arr2D[r, 1];
            }

            //move between rows
            for(int r = 0; r < 5; r++)
            {
                //move between columns
                for(int c = 0; c < 3; c++)
                {
                    Console.Write($"{arr2D[r, c],10}");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
