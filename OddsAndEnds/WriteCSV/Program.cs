using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            //need the using System.IO
            //need location a) absolute path b) find your special directory c) FileOpenDialog
            //StreamWriter to handle the outgoing data
            
            //by default files are replaced
            //you can add a parameter to the StreamWriter that indicates appending or not
            //if the file does not exist it will be created
            StreamWriter writer = new StreamWriter($"c:\\work\\outputfile.txt", append: false);
            writer.WriteLine("don welch, CPSC1012, 98");
            //writer.Close();
            //writer = new StreamWriter($"c:\\work\\outputfile.txt", append: true);
            writer.WriteLine("shirely ujest, CPSC1012, 49");
           // writer.Close();
           // writer = new StreamWriter($"c:\\work\\outputfile.txt", append: true);
            writer.WriteLine("lowand behold, CPSC1012, 78");
            writer.Close();
        }
    }
}
