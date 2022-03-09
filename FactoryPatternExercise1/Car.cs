using System;
namespace FactoryPatternExercise1
{
    public class Car : IVehicle
    {
        public Car()
        {
            Drive();
        }
        public void Drive()
        {
            Console.WriteLine($"Car is driving");
        }
    }
}
