using ProxyConsole.Proxy;
using System;

namespace ProxyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyClient();
            Console.WriteLine($"Data from Proxy Client = {proxy.GetData()}");

            Console.WriteLine("Press any key to close!");
            Console.ReadKey();
        }
    }
}
