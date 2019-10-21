using System;
using System.Threading;

namespace SingletonConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            //Test Safe Mode

            //SafeMode();
            WrongMode();

            Console.WriteLine("Pressione um tecla para encerrar");
            Console.ReadKey();
        }

        static void SafeMode()
        {
            Console.WriteLine(
                  "{0}\n{1}\n\n{2}\n",
                  "Se você estiver vendo o mesmo valor, então o singleton foi reutilizado (oh,yes!!!)",
                  "Se você estiver vendo valores diferentes, dois singletons serão criados(ops!!!)",
                  "RESULT:"
              );

            Thread process1 = new Thread(() =>
            {
                TestSingleton("First");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("Second");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestSingleton(string value)
        {
            SingletonThreadSafe singleton = SingletonThreadSafe.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }

        static void WrongMode()
        {
            // The client code.
            SingletonWrong s1 = SingletonWrong.GetInstance();
            SingletonWrong s2 = SingletonWrong.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton funciona, ambas as variáveis ​​contêm a mesma instância.");
            }
            else
            {
                Console.WriteLine("Singleton falhou, variáveis ​​contêm instâncias diferentes.");
            }
        }
    }
}
