using CommandConsole.Command;
using CommandConsole.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandConsole.ConcreteCommand
{
    public class FlipDownCommand : ICommand
    {
        private Light _light;

        public FlipDownCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
