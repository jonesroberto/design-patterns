using CompositeConsole.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeConsole.Leaf
{
    public class Contractor : IEmployed
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
    }
}
