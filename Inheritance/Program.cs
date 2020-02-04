using Inheritance.Vehicles;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle _bike = new Bike();
            Vehicle _truck = new Truck();
            Bike _electricBike = new ElectricBike();

            _bike.Go();
            _truck.Go();
            _electricBike.Go();
            Console.WriteLine( $"{_truck.a} {((Truck)_truck).a}" ); 
            _bike.Introduce();
            _truck.Introduce();
            _electricBike.Introduce();

            Console.ReadKey();
        }
    }
}
