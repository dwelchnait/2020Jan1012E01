using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  //required to do file i/o

namespace SpecialFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string Full_Path_File_Name = "";


            //you can prompt for the file name

            //location

            //use methods within the software to access the general special folders
            //   of your Windows file system
            //Documents, Downloads, Pictures, Music

            //this GetFolderPath will return C:\Users\xxxx\the special foldername
            //for the following statement C:\Users\Dwelch\Documents
            string specialpathname = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //Now, you must add any additional path structure to get to the specific
            //   folder within the special folder
            string FolderPath = specialpathname + @"\GitHub\2020Jan1012E01\";

            //I will assume that the require file will always be found at the
            //  root of the course class repository
            Console.Write("Enter the file name ex myfile.txt\t");
            string FileName = Console.ReadLine();

            Full_Path_File_Name = FolderPath + FileName;

            //setup for reading a file
            //a string variable is required to receive the data
            //   from the file.
            //the string will be filled with one row from your file
            //   on each file read.
            string readValue = "";

            //use a variable to count the rows in the file (optional)
            int counter = 0;

            //include what is referred to as "User Friendly error handling"
            //this is your try/catch/finally structure
            //the finally portion is ONLY needed if you need to close a
            //   connection to a data source

            StreamReader reader = null;
            try
            {
                //in the try is the code you will attempt to execute
                //if an error happens during the execution of the code
                //    an Exception is thrown by the system
                //any Exception thrown by the system is passed to the
                //    catch{} coding block for processing

                //to test the try/catch I will introduce a BAD path name
                //Full_Path_File_Name = @"c:\Users\DWelch\Documents\GitHub\2020Jan1012E01\bob.txt";

                //add the .Net Framework class that contains the code that
                //   will do the read of the file.
                //the require I/O class for reading is StreamReader located
                //    in the namespace System.IO
                //To attach the reader to the file, you need to pass the
                //    full path file name (fully qualified file name) as
                //    an argument to the class while it is being created
                //the reader is refer to as an instance of the class
                //the instance is phyiscal created when the new command is
                //    used in conjunction with the class name.
                reader = new StreamReader(Full_Path_File_Name);

                //gets a single row of the file
                readValue = reader.ReadLine();

                //if your line that was "read" is null, you have reach the 
                //   end of the file (eof)
                while (readValue != null)  //stop when you reach the end of the file
                {
                    counter++;
                    Console.WriteLine($"File line {counter} has a value of {readValue}\n");

                    //get the next line
                    readValue = reader.ReadLine();
                }
            } //eof try
            catch (Exception ex)
            {
                // .Message holds the error that occured during the processing
                //     of the code in your try{....}
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                //this is used if you need to close a data source such as an open file
                if (reader != null)
                reader.Close();
            }


            Console.ReadKey();
        }
    }
}
