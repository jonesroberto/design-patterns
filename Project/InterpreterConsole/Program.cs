using System;

namespace InterpreterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.BuildAndInterpretCommands();

        }
    }
}
