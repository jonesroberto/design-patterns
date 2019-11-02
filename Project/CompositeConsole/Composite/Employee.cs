using CompositeConsole.Component;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompositeConsole.Composite
{
    public class Employee : IEmployed, IEnumerable<IEmployed>
    {
        private List<IEmployed> _subordinates = new List<IEmployed>();

        public int EmpID { get; set; }
        public string Name { get; set; }

        public void AddSubordinate(IEmployed subordinate)
        {
            _subordinates.Add(subordinate);
        }

        public void RemoveSubordinate(IEmployed subordinate)
        {
            _subordinates.Remove(subordinate);
        }

        public IEmployed GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public IEnumerator<IEmployed> GetEnumerator()
        {
            foreach (IEmployed subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
