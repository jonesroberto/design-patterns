using AbstractFactoryConsole.AbstractProduct;

namespace AbstractFactoryConsole
{
    public interface VehicleFactory
    {
        Bike GetBike(string bike);
        Scooter GetScooter(string scooter);
        Car GetCar(string car);
    }
}
