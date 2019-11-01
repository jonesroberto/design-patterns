using AbstractFactoryConsole.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryConsole.ConcreteProduct
{
    public class RegularScooter : Scooter
    {
        public string Name()
        {
            return "Regular Scooter- Name";
        }
    }
}
