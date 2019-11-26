using CommandConsole.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandConsole.Invoker
{
    public class Switch
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }
    }
}
