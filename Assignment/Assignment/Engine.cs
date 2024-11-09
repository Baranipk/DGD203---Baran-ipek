using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Engine : IEngine
    {
        public int HorsePower { protected get; set; }
        public Engine() { }
        public Engine(int _horsePower) { HorsePower = _horsePower; }
        public void isWorking()
        {
            Console.WriteLine("(Engine Working) Trum Trum Track Trum Trum Track....!");
        }

        public void StartEngine()
        {
            Console.WriteLine("(Engine Start) Wunnnnnnnnn.....!");
        }

        public void StopEngine()
        {
            Console.WriteLine("(Engine Stop) _________");
        }

    }
}
