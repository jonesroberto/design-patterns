using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterConsole
{
    public class TerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine($"Terminal for {context.Name}.");
        }
    }
}
