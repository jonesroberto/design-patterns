using FactoryMethodConsole.ConcreateProduct;
using FactoryMethodConsole.Creator;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodConsole.ConcreateCreator
{
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException($"Vehicle {Vehicle} cannot be created");
            }
        }

    }
}
