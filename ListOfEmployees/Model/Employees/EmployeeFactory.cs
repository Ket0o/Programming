using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployees.Model.Employees
{
    public static class EmployeeFactory
    {
        private static Random _random = new Random();

        public static Employee Randomize()
        {
            Employee employee = new Employee();
            employee.Salary = _random.Next(30, 100);
            employee.FullName = "kk kk kk";
            employee.Post = "redovoi";
            employee.DateOfEmployment = new DateTime(1753, 1, 1);
            return employee;
        }
    }
}
