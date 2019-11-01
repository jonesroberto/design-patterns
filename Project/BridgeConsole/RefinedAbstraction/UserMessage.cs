using BridgeConsole.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeConsole.RefinedAbstraction
{
    public class UserMessage : Message
    {
        public string UserComments { get; set; }

        public override void Send()
        {
            string fullBody = string.Format("{0}\nUser Comments: {1}", Body, UserComments);
            MessageSender.SendMessage(Subject, fullBody);
        }
    }
}
