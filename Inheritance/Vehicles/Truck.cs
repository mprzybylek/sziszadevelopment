using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Vehicles
{
    class Truck : Vehicle
    {
        public int a=5;
        public override void Go()
        {
            Console.WriteLine("Truck goes");
        }
    }
}
