using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Vehicles
{
    abstract class Vehicle
    {
        public int a = 1;
        public void Introduce()
        {
            Console.WriteLine($"I am {this.GetType()}");
        }

        public virtual void Go()
        {
            Console.WriteLine("Vehicle goes");
        }
    }
}
