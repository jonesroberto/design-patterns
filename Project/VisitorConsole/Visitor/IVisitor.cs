using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorConsole
{
    public interface IVisitor
    {
        void VisitConcreteElementA(ConcreteElementA element);

        void VisitConcreteElementB(ConcreteElementB element);
    }
}
