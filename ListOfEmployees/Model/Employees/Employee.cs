using System;
using ListOfEmployees.Model.Classes;

namespace ListOfEmployees.Model.Employees
{
    public class Employee
    {
        private string _fullName;

        private string _post;

        private int _salary;

        public DateTime _dateOfEmployment;


        public string FullName
        {
            get { return _fullName; }
            set
            {
                Validator.NoMoreThan(value, Maximum_and_minimum_values.maxLengthFullName, FullName);
                _fullName = value;
            }
        }

        public string Post
        {
            get { return _post; }
            set
            {
                Validator.NoMoreThan(value, Maximum_and_minimum_values.maxLengthPost, Post);
                _post = value;
            }
        }

        public int Salary
        {
            get { return _salary; }
            set
            {
                Validator.AssertValueInRange("Salary", value, Maximum_and_minimum_values.minValueSalary, Maximum_and_minimum_values.maxValueSalary);
                _salary = value;
            }
        }

        public DateTime DateOfEmployment
        {
            get { return _dateOfEmployment; }
            set
            {
                Validator.NoMoreThan(value, "DateOfEmployment");
                _dateOfEmployment = value;
            }
        }

        public Employee(string fullName, string post, int salary, DateTime dateOfEmployment)
        {
            FullName = fullName;
            Post = post;
            Salary = salary;
            DateOfEmployment = dateOfEmployment;
        }
    }
}
