using AbstractFactoryConsole.Code.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryConsole.Code.Factory
{
    public interface IFurnitureFactory
    {
        public IChair CreateChair();
        public ICoffeeTable CreateCoffeeTable();
        public ISofa CreateSofa();
    }
}
