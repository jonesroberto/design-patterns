using AdapterConsole.Interfaces;
using System;
using System.Collections.Generic;

namespace AdapterConsole
{
    public class ThirdPartyBillingSystem
    {
        private ITarget employeeSource;

        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        public void ShowEmployeeList()
        {
            List<string> employee = employeeSource.GetEmployeeList();
            //To DO: Implement you business logic

            Console.WriteLine("######### Lista de  funcionários ##########");
            foreach (var item in employee)
            {
                Console.Write(item);
            }
        }
    }

}
