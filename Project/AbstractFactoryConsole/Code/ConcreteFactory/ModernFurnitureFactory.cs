using AbstractFactoryConsole.Code.Factory;
using AbstractFactoryConsole.Code.Products;
using System;

namespace AbstractFactoryConsole.Code.ConcreteFactory
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new Chair(Enum.ProductType.Modern);
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new CoffeeTable(Enum.ProductType.Modern);
        }

        public ISofa CreateSofa()
        {
            return new Sofa(Enum.ProductType.Modern);
        }
    }
}
