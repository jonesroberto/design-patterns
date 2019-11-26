using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterConsole
{
    public class Client
    {
        public void BuildAndInterpretCommands()
        {
            Context context = new Context("Dot Net context");
            NonterminalExpression root = new NonterminalExpression
            {
                Expression1 = new TerminalExpression(),
                Expression2 = new TerminalExpression()
            };

            root.Interpret(context);
        }
    }
}
