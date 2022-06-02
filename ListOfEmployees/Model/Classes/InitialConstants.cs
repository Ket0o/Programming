using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListOfEmployees.Model.Employees;

namespace ListOfEmployees.Model.Classes
{
    /// <summary>
    /// Хранит данные о максимальных и минимальных константах
    /// </summary>
    public static class InitialConstants
    {
        /// <summary>
        /// Максимальное количество символов для <see cref="Employee.FullName"/>.
        /// </summary>
        public static int maxLengthFullName = 100;

        /// <summary>
        /// Максимальное количество символов для <see cref="Employee.Post"/>.
        /// </summary>
        public static int maxLengthPost = 50;

        /// <summary>
        /// Максимальное значение для <see cref="Employee.Salary"/>
        /// </summary>
        public static int maxValueSalary = 500000;

        /// <summary>
        /// Минимальное значение для <see cref="Employee.Salary"/>
        /// </summary>
        public static int minValueSalary = 0;
    }
}
