using BridgeConsole.Bridge;
using System;

namespace BridgeConsole.Implementation
{
    public class MSMQSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"MSMQ\n{subject}\n{body}\n");
        }
    }
}
