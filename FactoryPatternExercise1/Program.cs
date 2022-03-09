using System;

namespace FactoryPatternExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"How many tires on this vehicle?");
            var tires = Console.ReadLine();            
            VehicleFactory.GetVehicle(tires);
        }
    }
}
