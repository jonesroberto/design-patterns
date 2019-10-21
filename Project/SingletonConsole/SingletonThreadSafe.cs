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

        // We now have a lock object that will be used to synchronize threads
        // during first access to the Singleton.
        private static readonly object _lock = new object();

        public static SingletonThreadSafe GetInstance(string value)
        {
            // This conditional is needed to prevent threads stumbling over the
            // lock once the instance is ready.
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
