using ChainOfResponsibilityConsole.InternalProcess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityConsole.Handler
{
    public abstract class Approver
    {
        // Loan event 
        public EventHandler<LoanEventArgs> Loan;

        // Loan event handler
        public abstract void LoanHandler(object sender, LoanEventArgs e);

        // Constructor
        public Approver()
        {
            Loan += LoanHandler;
        }

        public void ProcessRequest(Loan loan)
        {
            OnLoan(new LoanEventArgs { Loan = loan });
        }

        // Invoke the Loan event
        public virtual void OnLoan(LoanEventArgs e)
        {
            if (Loan != null)
            {
                Loan(this, e);
            }
        }

        // Sets or gets the next approver
        public Approver Successor { get; set; }
    }
}
