using PrototypeConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeConsole
{
    public class Developer : IEmployee
    {
        public int WordsPerMinute { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string PreferredLanguage { get; set; }

        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}", Name, Role, PreferredLanguage);
        }
    }
}
