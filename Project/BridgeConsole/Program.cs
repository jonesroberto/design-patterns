using BridgeConsole.Abstraction;
using BridgeConsole.Bridge;
using BridgeConsole.Implementation;
using BridgeConsole.RefinedAbstraction;
using System;

namespace BridgeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender email = new EmailSender();
            IMessageSender queue = new MSMQSender();
            IMessageSender web = new WebServiceSender();

            Message message = new SystemMessage();
            message.Subject = "Mensagem teste";
            message.Body = "Olá, Essa é uma mensagem de teste";

            message.MessageSender = email;
            message.Send();

            message.MessageSender = queue;
            message.Send();

            message.MessageSender = web;
            message.Send();

            UserMessage usermsg = new UserMessage();
            usermsg.Subject = "Mensagem Teste";
            usermsg.Body = "Olá, Essa é uma mensagem de teste";
            usermsg.UserComments = "Espero que todos consigam fazer o exemplo";

            usermsg.MessageSender = email;
            usermsg.Send();

            Console.ReadKey();
        }
    }
}
