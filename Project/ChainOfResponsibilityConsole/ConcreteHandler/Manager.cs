using ChainOfResponsibilityConsole.Handler;
using ChainOfResponsibilityConsole.InternalProcess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityConsole.ConcreteHandler
{
    class Manager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 100000)
            {
                Console.WriteLine($"{GetType().Name} approved request# {e.Loan.Number}");
            }
            else if (Successor != null)
            {
                Successor.LoanHandler(this, e);
            }
            else
            {
                Console.WriteLine(
                "Request# {0} requires an executive meeting!",
                e.Loan.Number);
            }
        }
    }
}
