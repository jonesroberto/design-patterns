using System;

namespace MementoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client code.
            Originator originator = new Originator("Super-memento.");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.Undo();

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }
    }
}
