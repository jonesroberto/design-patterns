using MediatorConsole.CollegueClasses;
using MediatorConsole.Mediator;
using System;

namespace MediatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();

            mediator.Colleague1 = new ConcreteColleagueA(mediator);
            mediator.Colleague2 = new ConcreteColleagueB(mediator);

            mediator.SendMessage(mediator.Colleague1, "Message mediator 1");
            mediator.SendMessage(mediator.Colleague2, "Message mediator 2");

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }
    }
}
