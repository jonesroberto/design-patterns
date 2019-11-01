using System;

namespace BuilderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleCreator = new VehicleCreator(new FerrariBuilder());
            vehicleCreator.CreateVehicle();
            var vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            Console.WriteLine("---------------------------------------------");

            vehicleCreator = new VehicleCreator(new HondaBuilder());
            vehicleCreator.CreateVehicle();
            vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();

            Console.ReadKey();
        }
    }
}
