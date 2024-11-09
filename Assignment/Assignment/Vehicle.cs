using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Vehicle
    {        
        internal float range;
        internal float maxSpeed;
        internal int cost;

        
        public bool doorIsOpen { get; private set; }

        public void Open()
        {
            doorIsOpen = true;

            Console.WriteLine("Door is open");
        }

        public void Close() 
        {
            doorIsOpen = false;

            Console.WriteLine("Door is closed");
        }
	}
}
