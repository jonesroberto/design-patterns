using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorConsole
{
    public interface Iterator
    {
        object Current { get; }
        bool Next();
    }
}
