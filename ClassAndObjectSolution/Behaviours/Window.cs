using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaviours
{
    public class Window
    {
        private double _Width;
        public string Model { get; set; }
        public double Height { get; set; }

        public double Width
        {
            //"right side" of an assignment statement or using it
            get { return _Width; }
            //"left side" of an assignment statement
            set
            {
                if (value <= 0.0)
                {
                    throw new Exception("You must have a positive number for your width.");
                }
                else
                {
                    _Width = value;
                }
            }
        }

        public Window()
        {
            //overriding the system defaults for numerics
            Height = 1.25;
            Width = 1.25;
        }

        public Window(string model, double height, double width)
        {
            Model = model;
            Height = height;
            //best practice for assigning values is to go through the property
            Width = width;
        }

        //Behaviours (a.k.a. methods)

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return (Height + Width) * 2;
        }

        public double Estimate(double areaunitprice, int areaunit)
        {
            double area = Area(); //calling an internal behaviour
            return (area / areaunit) * areaunitprice;
        }

        public override string  ToString()
        {
            return $"Model: {Model}  Height: {Height}   Width: {Width}";
        }
    }
}
