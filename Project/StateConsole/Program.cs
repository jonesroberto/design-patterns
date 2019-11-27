using System;

namespace StateConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new ConcreteStateA());
            context.Request1();
            context.Request2();

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }
    }
}
