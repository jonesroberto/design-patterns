using FactoryMethodConsole;
using FactoryMethodConsole.ConcreateCreator;
using FactoryMethodConsole.Creator;
using System;

namespace DesignPatternsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            Console.ReadKey();
        }
    }
}
