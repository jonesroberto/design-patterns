using DecoratorConsole.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorConsole.ConcreteComponent
{
    public class HondaCity : IVehicle
    {
        public string Make
        {
            get { return "HondaCity"; }
        }

        public string Model
        {
            get { return "CNG"; }
        }

        public double Price
        {
            get { return 1000000; }
        }
    }
}
