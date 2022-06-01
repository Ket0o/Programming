using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListOfEmployees.Model.Employees;

namespace ListOfEmployees.Model.Classes
{
    public class Sorting
    {
        public static List<Employee> SortedEmployees(List<Employee> employees)
        {
            var sortedListEmployees = from employee in employees
                                      orderby employee.FullName
                                      select employee;



            return sortedListEmployees.ToList();
        }
    }
}
