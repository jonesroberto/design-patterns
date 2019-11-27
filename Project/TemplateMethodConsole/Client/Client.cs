using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodConsole
{
    class Client
    {
        public static void ClientCode(AbstractClass abstractClass)
        {
            abstractClass.TemplateMethod();
        }
    }
}
