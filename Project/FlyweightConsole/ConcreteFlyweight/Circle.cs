using FlyweightConsole.Flyweight;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightConsole.ConcreteFlyweight
{
    class Circle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Circle");
        }
    }
}
