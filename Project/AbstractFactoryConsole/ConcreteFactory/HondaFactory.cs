using AbstractFactoryConsole.AbstractProduct;
using AbstractFactoryConsole.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryConsole.ConcreteFactory
{
    class HondaFactory : VehicleFactory
    {
        public Bike GetBike(string bike)
        {
            switch (bike)
            {
                case "Sports":
                    return new SportsBike();
                case "Regular":
                    return new RegularBike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", bike));
            }
        }

        public Car GetCar(string car)
        {
            switch (car)
            {
                case "Sports":
                    return new SportsCar();
                case "Regular":
                    return new RegularCar();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", car));
            }
        }

        public Scooter GetScooter(string scooter)
        {
            switch (scooter)
            {
                case "Sports":
                    return new Scooty();
                case "Regular":
                    return new RegularScooter();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", scooter));
            }
        }
    }
}
