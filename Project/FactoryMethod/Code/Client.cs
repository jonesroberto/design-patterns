using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.FactoryMethod
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the Truck.");
            ClientCode(new ConcreteCreatorTruck());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the Ship.");
            ClientCode(new ConcreteCreatorShip());

            Console.WriteLine("Press any button to close");
            Console.ReadLine();
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.Deliver());
        }
    }
}
