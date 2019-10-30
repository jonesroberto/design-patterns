using System;

namespace BuilderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new HouseDirector();
            var builder = new HouseConcreteBuilder();
            director.HouseBuilder = builder;

            Console.WriteLine("Build Simple House:");
            director.BuildHouse();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Buil Full House:");
            director.BuildHouseFull();
            Console.WriteLine(builder.GetProduct().ListParts());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Build Custom House:");
            builder.BuildDoors();
            builder.BuildRoof();
            builder.BuildWalls();
            builder.BuildWindows();
            builder.BuildGarden();
            Console.Write(builder.GetProduct().ListParts());

            Console.ReadKey();
        }
    }
}
