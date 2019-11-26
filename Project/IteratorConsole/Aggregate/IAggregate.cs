using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorConsole
{
    public interface IAggregate
    {
        Iterator CreateIterator();
    }
}
