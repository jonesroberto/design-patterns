using AbstractFactoryConsole.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryConsole.ConcreteProduct
{
    public class RegularCar : Car
    {
        public string Name()
        {
            return "Regular Car- Name";
        }
    }
}
