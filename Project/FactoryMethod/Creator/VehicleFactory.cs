using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodConsole.Creator
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string vehicle);

    }
}
