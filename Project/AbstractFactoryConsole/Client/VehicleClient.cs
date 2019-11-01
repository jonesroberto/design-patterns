using AbstractFactoryConsole.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryConsole.Client
{
    public class VehicleClient
    {
        Bike bike;
        Scooter scooter;
        Car car;

        public VehicleClient(VehicleFactory factory, string type)
        {
            bike = factory.GetBike(type);
            scooter = factory.GetScooter(type);
            car = factory.GetCar(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }

        public string GetScooterName()
        {
            return scooter.Name();
        }

        public string GetCar()
        {
            return car.Name();
        }
    }
}
