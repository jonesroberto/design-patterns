using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterConsole
{
    public class HRSystem
    {
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];

            employees[0] = new string[] { "100", "Cesar Silva", "Coordenador de TI" };
            employees[1] = new string[] { "101", "Igor Kawata", "Coordenador de TI" };
            employees[2] = new string[] { "102", "Renato Novelli", "Desenvolvedor Senior" };
            employees[3] = new string[] { "103", "André Cirelli", "Product Owner" };

            return employees;
        }
    }
}
