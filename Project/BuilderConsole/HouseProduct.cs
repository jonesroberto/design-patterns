using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderConsole
{
    public class HouseProduct
    {
        private List<HousePart> _houseParts = new List<HousePart>();

        public void Add(HousePart housePart)
        {
            _houseParts.Add(housePart);
        }

        public string ListParts()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var housePart in _houseParts)
            {
                sb.Append($" {housePart.Name}");
            }
           
            return $"House parts: {sb}";
        }
    }
}
