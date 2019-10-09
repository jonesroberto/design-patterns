using AbstractFactoryConsole.Code.Factory;
using AbstractFactoryConsole.Code.Products;

namespace AbstractFactoryConsole.Code.ConcreteFactory
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new Chair(Enum.ProductType.Victorian);
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new CoffeeTable(Enum.ProductType.Victorian);
        }

        public ISofa CreateSofa()
        {
            return new Sofa(Enum.ProductType.Victorian);
        }
    }
}
