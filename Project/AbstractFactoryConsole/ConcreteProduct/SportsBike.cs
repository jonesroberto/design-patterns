using AbstractFactoryConsole.AbstractProduct;

namespace AbstractFactoryConsole.ConcreteProduct
{
    public class SportsBike : Bike
    {
        public string Name()
        {
            return "Sports Bike- Name";
        }
    }
}
