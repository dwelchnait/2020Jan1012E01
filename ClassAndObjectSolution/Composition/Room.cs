using Behaviours; //namespace to Opening class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class Room
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Room must have a name");
                }
                else
                {
                    _Name = value;
                }
            }
        }
        public List<Wall> Walls { get; set; }
        public List<Opening> Openings { get; set; }

        public Room()
        {
            //need to create the physical List<T> to hold
            //   instances added to the list
            //default of a List<T> is the same as any object: null
            Walls = new List<Wall>();
            Openings = new List<Opening>();
        }
    }
}
