using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.FactoryMethod
{
    public class ConcreteCreatorTruck : Creator
    {
        public override ITransport FactoryMethod()
        {
            return new ConcreteTruck();
        }
    }
}
