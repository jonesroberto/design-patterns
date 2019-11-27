using System;

namespace TemplateMethodConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }
    }
}
