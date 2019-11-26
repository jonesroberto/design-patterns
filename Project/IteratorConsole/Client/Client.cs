using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorConsole
{
    public class Client
    {
        public void UseIterator()
        {
            ConcreteAggregate aggr = new ConcreteAggregate();
            aggr.Add("One");
            aggr.Add("Two");
            aggr.Add("Three");
            aggr.Add("Four");
            aggr.Add("Five");

            Iterator iterator = aggr.CreateIterator();
            while (iterator.Next())
            {
                string item = (string)iterator.Current;
                Console.WriteLine(item);
            }
        }
    }
}
