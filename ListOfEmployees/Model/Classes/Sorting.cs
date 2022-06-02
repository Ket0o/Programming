using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListOfEmployees.Model.Employees;

namespace ListOfEmployees.Model.Classes
{
    /// <summary>
    /// Класс реализует сортировку данных.
    /// </summary>
    public class Sorting
    {
        /// <summary>
        /// Проводит сортировку коллекции рабочих по полному имени.
        /// </summary>
        /// <param name="employees">Коллекция класса <see cref="Employee"/></param>
        /// <returns>Возвращает отсортированную коллекцию рабочих.</returns>
        public static List<Employee> SortedEmployees(List<Employee> employees)
        {
            var sortedListEmployees = from employee in employees
                                      orderby employee.FullName
                                      select employee;



            return sortedListEmployees.ToList();
        }
    }
}
