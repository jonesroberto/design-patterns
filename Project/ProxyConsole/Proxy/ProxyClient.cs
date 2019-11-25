using ProxyConsole.RealSubject;
using ProxyConsole.Subject;
using System;

namespace ProxyConsole.Proxy
{
    public class ProxyClient : IClient
    {
        RealClient client = new RealClient();
        public ProxyClient()
        {
            Console.WriteLine("ProxyClient: Initialized");
        }

        public string GetData()
        {
            return client.GetData();
        }
    }
}
