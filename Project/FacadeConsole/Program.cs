using FacadeConsole.Facade;
using System;

namespace FacadeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFacade facade = new CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();

        }
    }
}
