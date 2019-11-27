using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorConsole
{
    public class ConcreteElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public string ExclusiveMethodOfConcreteElementA()
        {
            return "A";
        }
    }
}
