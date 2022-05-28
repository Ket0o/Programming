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

        public static Employee CreateStandart()
        {
            Employee employee = new Employee();
            employee.Salary = 0;
            employee.FullName = "Имя Фамилия Отчество";
            employee.Post = "Пост";
            employee.DateOfEmployment = new DateTime(1753, 1, 1);
            return employee;
        }
    }
}
