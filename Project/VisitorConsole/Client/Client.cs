using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorConsole
{
    public class Client
    {
        public static void ClientCode(List<IElement> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}
