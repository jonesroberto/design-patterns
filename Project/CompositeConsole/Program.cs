using CompositeConsole.Composite;
using CompositeConsole.Leaf;
using System;

namespace CompositeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Thiago = new Employee { EmpID = 1, Name = "Thiago" };

            Employee Gabriel = new Employee { EmpID = 2, Name = "Gabriel" };
            Employee Jones = new Employee { EmpID = 3, Name = "Jones" };

            Thiago.AddSubordinate(Gabriel);
            Thiago.AddSubordinate(Jones);

            Employee Barbara = new Employee { EmpID = 4, Name = "Barbara" };
            Employee Andre = new Employee { EmpID = 5, Name = "André" };

            Gabriel.AddSubordinate(Barbara);
            Gabriel.AddSubordinate(Andre);

            Employee Cesar = new Employee { EmpID = 6, Name = "Cesar" };
            Employee Igor = new Employee { EmpID = 7, Name = "Igor" };

            Contractor Gisnando = new Contractor { EmpID = 8, Name = "Gisnando" };
            Contractor Gerlandio = new Contractor { EmpID = 9, Name = "Gerlandio" };

            Jones.AddSubordinate(Cesar);
            Jones.AddSubordinate(Igor);
            Jones.AddSubordinate(Gisnando);
            Jones.AddSubordinate(Gerlandio);

            Console.WriteLine($"EmpID={Thiago.EmpID}, Name={Thiago.Name}");

            foreach (Employee manager in Thiago)
            {
                Console.WriteLine($"\n EmpID={manager.EmpID}, Name={manager.Name}");

                foreach (var employee in manager)
                {
                    Console.WriteLine($" \t EmpID={employee.EmpID}, Name={employee.Name}");
                }
            }
            Console.ReadKey();
        }
    }

}
