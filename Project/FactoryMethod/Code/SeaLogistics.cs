using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.FactoryMethod
{
    public class SeaLogistics : Creator
    {
        public override ITransport FactoryMethod()
        {
            return new Ship();
        }
    }
}
