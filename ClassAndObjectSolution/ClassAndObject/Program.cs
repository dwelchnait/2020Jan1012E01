using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of my Assessment class
            Assessment myInstance = new Assessment();

            //use the instance
            //which action in the property is being used
            //   on the following statements?
            //set (instance is on the "left side" of an assignment
            myInstance.FirstName = "don";
            myInstance.LastName = "welch";
            myInstance.AssessmentName = "core portfolio 5";
            myInstance.Mark = 99.9;
            //static or Instance?
            //static using the class name WITHOUT creating the class
            //get (instance is on the "right side" of the statement
            Console.WriteLine($"first name: {myInstance.FirstName} last name {myInstance.LastName}" +
                $" Assessment {myInstance.AssessmentName} mark: {myInstance.Mark} " +
                $"comments <{myInstance.Comment}>");
        }
    }
}
