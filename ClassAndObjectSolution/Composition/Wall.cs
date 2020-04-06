using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class Wall
    {
        private double _Length;
        private double _Height;

        public double Length
        {
            get { return _Length; }
            set 
            {
                if (value <=0.0)
                {
                    throw new Exception("Wall length must be greater than 0.0");
                }
                else
                {
                    _Length = value;
                }
            }
        }

        public double Height
        {
            get { return _Height; }
            set
            {
                if (value <= 0.0)
                {
                    throw new Exception("Wall height must be greater than 0.0");
                }
                else
                {
                    _Height = value;
                }
            }
        }

        public Wall()
        {
            Length = 4.25;
            Height = 2.65;
        }

        public Wall(double length, double height)
        {
            Length = length;
            Height = height;
        }

        public double Area()
        {
            return Length * Height;
        }



    }
}
