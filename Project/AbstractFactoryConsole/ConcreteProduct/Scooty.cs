using AbstractFactoryConsole.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryConsole.ConcreteProduct
{
    public class Scooty : Scooter
    {
        public string Name()
        {
            return "Scooty- Name";
        }
    }
}
