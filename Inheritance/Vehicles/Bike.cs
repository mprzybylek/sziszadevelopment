using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Vehicles
{
    class Bike : Vehicle
    {
        public bool Foldable { get; set; }

        public override void Go()
        {
            Console.WriteLine("Bike goes");
        }
    }
}
