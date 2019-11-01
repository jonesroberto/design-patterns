using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeConsole.Interfaces
{
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }
}
