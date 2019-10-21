using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonConsole
{
    //É muito fácil implementar um Singleton desleixado.
    //Você só precisa ocultar o construtor e implementar um método de criação estático.
    //A mesma classe se comporta incorretamente em um ambiente multithread.
    //Vários threads podem chamar o método de criação simultaneamente e obter várias instâncias da classe Singleton.

    class SingletonWrong
    {
        private SingletonWrong() { }

        private static SingletonWrong _instance;

        public static SingletonWrong GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonWrong();
            }
            return _instance;
        }

        public static void SomeBusinessLogic()
        {
        }
    }
}
