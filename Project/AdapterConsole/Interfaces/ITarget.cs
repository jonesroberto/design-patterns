using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterConsole.Interfaces
{
    public interface ITarget
    {
        List<string> GetEmployeeList();
    }
}
