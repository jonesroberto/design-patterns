using AbstractFactoryConsole.Code.Factory;
using AbstractFactoryConsole.Code.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryConsole.Code.ConcreteFactory
{
    public class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new Chair(Enum.ProductType.ArtDeco);
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new CoffeeTable(Enum.ProductType.ArtDeco);
        }

        public ISofa CreateSofa()
        {
            return new Sofa(Enum.ProductType.ArtDeco);
        }
    }
}
