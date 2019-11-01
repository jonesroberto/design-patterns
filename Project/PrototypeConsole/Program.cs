using System;

namespace PrototypeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new Developer();
            dev.Name = "Cesar Silva";
            dev.Role = "Coordenador Ti";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Igor Kawata"; //Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            Manager manager = new Manager();
            manager.Name = "Jones Roberto";
            manager.Role = "Gerente";
            manager.WordsPerMinute = 120;

            Manager managerCopy = (Manager)manager.Clone();
            managerCopy.Name = "Leonidas Leme";
            managerCopy.WordsPerMinute = 110;//Not mention Role, it will copy above

            Console.WriteLine(manager.GetDetails());
            Console.WriteLine(managerCopy.GetDetails());

            Console.ReadKey();
        }
    }
}
