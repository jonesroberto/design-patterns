using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.FactoryMethod
{
    public class RoadLogistics : Creator
    {
        public override ITransport FactoryMethod()
        {
            return new Truck();
        }
    }
}
