using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorConsole
{
    public class ConcreteElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public string SpecialMethodOfConcreteElementB()
        {
            return "B";
        }
    }
}
