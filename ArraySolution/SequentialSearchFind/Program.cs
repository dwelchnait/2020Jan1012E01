using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace SequentialSearchFind
{
    
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //declare an integer array of 25 elements
            int[] myArray = new int[25];
            //integer variable to indicate the "logical size" of the array
            //the "logical size" refers to the number of elements in the array
            //the declared size (25) is referred to as the phyiscal size
            int logicalsize = 0;
            int phyiscalsize = 25;

            string Full_Path_File_Name = "";
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;
            string readValue = "";
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readValue = reader.ReadLine();
                while (readValue != null && logicalsize < phyiscalsize)  
                {
                    myArray[logicalsize] = int.Parse(readValue);
                    logicalsize++;
                    //get the next line
                    readValue = reader.ReadLine();
                }
            } //eof try
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            Console.WriteLine($"The number of elements in the array is {logicalsize}");
            for(int loopcounter = 0; loopcounter < logicalsize; loopcounter++)
            {
                Console.WriteLine($"At array index {loopcounter} there is a value of {myArray[loopcounter]}");
            }

            //Sequential Search
            //is it there
            Console.Write($"Enter a number:\t");
            int searcharg = int.Parse(Console.ReadLine());

            bool found = false;
            int searchindex = 0;
            //condition expression 
            //  a)continue to look until you looked at everything
            //  b)continue if not found
            //searchcounter is a index (0 based)
            //logicalsize is a natural count (1 based)
            while (searchindex < logicalsize && !found)
            {
                if (myArray[searchindex] == searcharg)
                {
                    //number was found
                    //stop
                    //searchcounter will be the index of the array location where
                    //    the searcharg was first found
                    found = true;
                }
                else
                {
                    //increment to look at the next element in the array
                    searchindex++;
                }
            }
            if(found)
            {
                Console.WriteLine($"{searcharg} was found at index {searchindex}");
            }
            else
            {
                Console.WriteLine($"{searcharg} was not found anywhere in the {logicalsize} array elements");
            }

            //count the number of occurances in the array
            searchindex = 0;
            int foundcount = 0;
            found = false;
            //this could also be coded using a for loop BECAUSE
            //    you are looking at ALL the elements (actual count)
            //for(int searchindex = 0; searchindex < logicalsize; searchindex++)
            //I DO NOT want to stop when I find the first occurance in the loop
            while (searchindex < logicalsize)
            {
                if (myArray[searchindex] == searcharg)
                {
                    //number was found
                    //stop
                    //searchcounter will be the index of the array location where
                    //    the searcharg was first found
                    found = true;
                    foundcount++;

                }

                //increment to look at the next element in the array
                searchindex++;

            }
            //if (foundcount > 0) then you would not need the boolean found flag
            if (found)
            {
                Console.WriteLine($"{foundcount} occurances of {searcharg} were located in the array");
            }
            else
            {
                Console.WriteLine($"{searcharg} was not found anywhere in the {logicalsize} array elements");
            }
        }
    }
}
