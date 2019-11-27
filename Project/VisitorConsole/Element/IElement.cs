using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorConsole
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
