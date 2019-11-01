using AbstractFactoryConsole.AbstractProduct;

namespace AbstractFactoryConsole.ConcreteProduct
{
    public class RegularBike : Bike
    {
        public string Name()
        {
            return "Regular Bike- Name";
        }
    }
}
