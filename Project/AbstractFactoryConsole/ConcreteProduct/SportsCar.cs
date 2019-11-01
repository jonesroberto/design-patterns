using AbstractFactoryConsole.AbstractProduct;

namespace AbstractFactoryConsole.ConcreteProduct
{
    public class SportsCar : Car
    {
        public string Name()
        {
            return "Sports Car - Name";
        }
    }
}
