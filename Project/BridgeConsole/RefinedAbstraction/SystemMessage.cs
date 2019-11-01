using BridgeConsole.Abstraction;

namespace BridgeConsole.RefinedAbstraction
{
    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }
}
