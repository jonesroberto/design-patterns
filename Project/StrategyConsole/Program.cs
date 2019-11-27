using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine("Client: ");
            context.SetStrategy(new PositionEquities());
            context.GetCustomerPosition(335962);

            Console.WriteLine();

            Console.WriteLine("Client: ");
            context.SetStrategy(new PositionFunds());
            context.GetCustomerPosition(335962);
        }
    }
}
