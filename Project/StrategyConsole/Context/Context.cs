using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyConsole
{
    class Context
    {
        private IStrategy _strategy;

        public Context()
        { }

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void GetCustomerPosition(long customerCode)
        {
            var result = this._strategy.GetCustomerPosition(customerCode);

            Console.WriteLine($"Customer: {result.Name} - Position {result.Value}");
        }
    }
}
