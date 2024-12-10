using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Projekt_Dec_24.Tables
{
    public class Employees
    {
        public int EmployeeId { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }

        public Employees(int employeeId, string employeeEmail, string employeeFirstName, string employeeLastName)
        {
            EmployeeId = employeeId;
            EmployeeEmail = employeeEmail;
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
        }

        public string EmployeeInformation
        {
            get { return $"{EmployeeFirstName} {EmployeeLastName}, {EmployeeEmail}"; }
        }
    }
}
