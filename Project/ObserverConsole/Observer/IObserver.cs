using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverConsole
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
