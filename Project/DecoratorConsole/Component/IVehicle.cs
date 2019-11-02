using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorConsole.Component
{
    public interface IVehicle
    {
        string Make { get; }
        string Model { get; }
        double Price { get; }
    }

}
