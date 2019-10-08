using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.FactoryMethod
{
    public abstract class Creator
    {
        public abstract ITransport FactoryMethod();

        public string Deliver()
        {
            var product = FactoryMethod();
            var result = "Creator: Método básico de criação "
                + product.Deliver();

            return result;
        }
    }
}
