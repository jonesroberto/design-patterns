using CommandConsole.Command;
using CommandConsole.ConcreteCommand;
using CommandConsole.Invoker;
using CommandConsole.Receiver;
using System;

namespace CommandConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Commands (ON/OFF) : ");
            string cmd = Console.ReadLine();

            Light lamp = new Light();
            ICommand switchUp = new FlipUpCommand(lamp);
            ICommand switchDown = new FlipDownCommand(lamp);

            Switch s = new Switch();

            switch (cmd)
            {
                default:
                    Console.WriteLine("Command \"ON\" or \"OFF\" is required.");
                    break;
                case "ON":
                    s.StoreAndExecute(switchUp);
                    break;
                case "OFF":
                    s.StoreAndExecute(switchDown);
                    break;
            }

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
