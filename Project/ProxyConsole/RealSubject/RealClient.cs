using ProxyConsole.Subject;
using System;

namespace ProxyConsole.RealSubject
{
    public class RealClient : IClient
    {
        string Data;
        public RealClient()
        {
            Console.WriteLine("Real Client: Initialized");
            Data = "XP Inc. Medium";
        }

        public string GetData()
        {
            return Data;
        }
    }
}
