using AbstractFactoryConsole.Code.ConcreteFactory;
using AbstractFactoryConsole.Code.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryConsole.Code
{
    class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the VictorianFurnitureFactory factory type...");
            ClientMethod(new VictorianFurnitureFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the ModernFurnitureFactory factory type...");
            ClientMethod(new ModernFurnitureFactory());

            Console.WriteLine("Client: Testing the same client code with the ArtDecoFurnitureFactory factory type...");
            ClientMethod(new ArtDecoFurnitureFactory());
        }

        public void ClientMethod(IFurnitureFactory factory)
        {
            var productA = factory.CreateChair();
            var productB = factory.CreateCoffeeTable();
            var productC = factory.CreateSofa();

            Console.WriteLine(productA.Get());
            Console.WriteLine(productB.Get());
            Console.WriteLine(productC.Get());
        }
    }

}
