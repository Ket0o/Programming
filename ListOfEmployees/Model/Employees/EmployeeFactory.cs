using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployees.Model.Employees
{
    /// <summary>
    /// Класс создает шаблон для заполнения информации о рабочем.
    /// </summary>
    public static class EmployeeFactory
    {
        /// <summary>
        /// Создание шаблона для заполнения информации о рабочем.
        /// </summary>
        /// <returns>Шаблон для заполнения информации о рабочем.</returns>
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
