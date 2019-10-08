using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.FactoryMethod
{
    public class Truck : ITransport
    {
        public string Deliver()
        {
            return "{Result of Deliver Truck}";
        }
    }
}

