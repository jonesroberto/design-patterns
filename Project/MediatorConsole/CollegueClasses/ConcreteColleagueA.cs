using MediatorConsole.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorConsole.CollegueClasses
{
    public class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(IMediator mediator) : base(mediator) { }

        public void Send(string msg)
        {
            Console.WriteLine($"A send message:{msg}");
            _mediator.SendMessage(this, msg);
        }

        public void Receive(string msg)
        {
            Console.WriteLine($"A receive message:{msg}");
        }
    }
}
