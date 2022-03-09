using System;
namespace FactoryPatternExercise1
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string tires)
        {
            switch (tires)
            {
                case string n when n == "2" || n.ToLower() == "two":
                    return new Motorcycle();                    
                case string n when n == "4" || n.ToLower() == "four":
                    return new Car();
                default:
                    return new Car();
            }
        }
    }
}
