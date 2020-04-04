using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WriteCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter($"c:\\work\\somefile.txt", append: true);  
            writer.WriteLine("don welch, cpsc1012, 89");
            writer.Close();
            writer = new StreamWriter($"c:\\work\\somefile.txt", append: true);
            writer.WriteLine("shirely ujest, cpsc1012, 99");
            writer.Close();
            writer = new StreamWriter($"c:\\work\\somefile.txt", append: true);
            writer.WriteLine("jerry kan, cpsc1012, 39");
            writer.Close();
            writer = new StreamWriter($"c:\\work\\somefile.txt", append: true);
            writer.WriteLine("iam coder, cpsc1012, 69");
            writer.Close();
        }
    }
}
