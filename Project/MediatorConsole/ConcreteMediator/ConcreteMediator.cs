using MediatorConsole.CollegueClasses;
using MediatorConsole.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorConsole
{
    public class ConcreteMediator : IMediator
    {
        public ConcreteColleagueA Colleague1 { get; set; }

        public ConcreteColleagueB Colleague2 { get; set; }

        public void SendMessage(Colleague caller, string msg)
        {
            if (caller == Colleague1)
                Colleague2.Receive(msg);
            else
                Colleague1.Receive(msg);
        }
    }
}
