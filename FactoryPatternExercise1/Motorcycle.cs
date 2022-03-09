using System;
namespace FactoryPatternExercise1
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Drive();
        }
        public void Drive()
        {
            Console.WriteLine($"Motorcycle is driving");
        }
    }
}
