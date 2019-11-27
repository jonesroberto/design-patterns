using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyConsole
{
    interface IStrategy
    {
        CustomerPositionModel GetCustomerPosition(long customerCode);
    }
}
