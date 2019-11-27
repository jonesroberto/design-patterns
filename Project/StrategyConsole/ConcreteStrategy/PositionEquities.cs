using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyConsole
{
    class PositionEquities : IStrategy
    {
        public CustomerPositionModel GetCustomerPosition(long customerCode)
        {
            if (customerCode > 0)
            {
                var result=  new CustomerPositionModel
                {
                    Name = $"Cliente {customerCode}",
                    Value = 100000
                };

                Console.WriteLine($"{result.Name} - {result.Value}");

                return result;
            }

            return new CustomerPositionModel();
        }
    }
}
