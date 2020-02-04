using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Vehicles
{
    class ElectricBike : Bike
    {
        public override void Go()
        {
            Console.WriteLine("ElectricBike goes");
        }
    }
}
