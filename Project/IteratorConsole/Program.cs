using System;

namespace IteratorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.UseIterator();

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }
    }
}
