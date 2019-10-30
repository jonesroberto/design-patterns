using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonConsole
{
    //Para corrigir o problema, você deve sincronizar os threads durante
    //a primeira criação do objeto Singleton.
    class SingletonThreadSafe
    {
        private SingletonThreadSafe() { }

        private static SingletonThreadSafe _instance;

        private static readonly object _lock = new object();

        public static SingletonThreadSafe GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonThreadSafe();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }

        public string Value { get; set; }
    }
}
