using System;
using ListOfEmployees.Model.Classes;

namespace ListOfEmployees.Model.Employees
{
    public class Employee
    {
        private string _fullName;

        private string _post;

        private int _salary;

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
                Validator.AssertValueInRange("Salary", value, 0, 500000);
            }
        }

        public DateTime _dateOfEmployment { get; set; }
    }
}
