using System;
using System.Collections.Generic;

namespace VisitorConsole
{
    //ObjectStructure
    class Program
    {
        static void Main(string[] args)
        {
            List<IElement> components = new List<IElement>
            {
                new ConcreteElementA(),
                new ConcreteElementB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new ConcreteVisitor2();
            Client.ClientCode(components, visitor2);

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }
    }
}
