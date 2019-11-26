using MediatorConsole.CollegueClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorConsole.Mediator
{
    public interface IMediator
    {
        void SendMessage(Colleague caller, string msg);
    }
}
