using System;

namespace ChainOfResponsibilityConsole.InternalProcess
{
    public class LoanEventArgs : EventArgs
    {
        internal Loan Loan { get; set; }
    }

}
