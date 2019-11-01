using BridgeConsole.Bridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeConsole.Implementation
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Email\n{subject}\n{body}\n");
        }
    }
}
