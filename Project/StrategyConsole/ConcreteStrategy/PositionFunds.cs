using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyConsole
{
    public class PositionFunds : IStrategy
    {
        public CustomerPositionModel GetCustomerPosition(long customerCode)
        {
            if (customerCode > 0)
            {
                var result = new CustomerPositionModel
                {
                    Name = $"Cliente {customerCode}",
                    Value = 2000
                };

                Console.WriteLine($"{result.Name} - {result.Value}");

                return result;
            }

            return new CustomerPositionModel();
        }
    }
}
