using BridgeConsole.Bridge;
using System;

namespace BridgeConsole.Implementation
{
    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Web Service\n{subject}\n{body}\n");
        }
    }
}
