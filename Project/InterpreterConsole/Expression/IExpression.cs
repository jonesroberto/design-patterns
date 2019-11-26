using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterConsole
{
    public interface IExpression
    {
        void Interpret(Context context);
    }

}
