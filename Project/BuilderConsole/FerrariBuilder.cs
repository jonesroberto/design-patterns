using BuilderConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderConsole
{
    public class FerrariBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();
        public void SetModel()
        {
            objVehicle.Model = "Ferrari 360";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "4 Stroke";
        }

        public void SetTransmission()
        {
            objVehicle.Transmission = "280 Km/hr";
        }

        public void SetBody()
        {
            objVehicle.Body = "Glass Fiber";
        }

        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Seat Cover");
            objVehicle.Accessories.Add("Rear Mirror");
            objVehicle.Accessories.Add("Helmet");
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }
}
