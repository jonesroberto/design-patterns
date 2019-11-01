using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeConsole.Bridge
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}
