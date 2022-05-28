using System;
using System.Collections.Generic;
using ListOfEmployees.Model.Employees;
using ListOfEmployees.Model.Classes;
using System.Windows.Forms;
using System.Linq;

namespace ListOfEmployees
{
    public partial class MainForm : Form
    {
        private List<Employee> _employees;

        private Employee _currentEmployee;

        public MainForm()
        {
            InitializeComponent();

            _employees = new List<Employee>();
        }

        public List<Employee> SortedEmployees(List<Employee> employees)
        {
            var sortedListEmployees = from employee in employees
                                      orderby employee.FullName
                                      select employee;

            

            return sortedListEmployees.ToList();
        }

        private int IndexById ()
        {
            _employees = SortedEmployees(_employees);


            int currentEmployeeId = _currentEmployee.Id;

            int index = -1;

            for(int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Id == currentEmployeeId)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        private void ClearEmployeeInfo()
        {
           
            fullNameTextBox.Clear(); /// Ошибка
            postTextBox.Clear();
            salaryTextBox.Clear();
            dateTimePicker.Value = new DateTime(1753, 1, 1);
        }

        private void UpdateEmployeeInfo(int selectedIndex)
        {
            listBoxEmployees.Items.Clear();

            _employees = SortedEmployees(_employees);

            foreach (Employee employee in _employees)
            {
                listBoxEmployees.Items.Add($"{employee.FullName}");
            }

            if (selectedIndex == -1) return;

            listBoxEmployees.SelectedIndex = selectedIndex; /// Ошибка
        }



        private void plusButton_Click(object sender, EventArgs e)
        {
            _currentEmployee = EmployeeFactory.CreateStandart();
            _employees.Add(_currentEmployee);
            listBoxEmployees.Items.Add(_currentEmployee.FullName);
        }

        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedItem != null)
            {
                int indexSelectedEmployee = listBoxEmployees.SelectedIndex;
                _currentEmployee = _employees[indexSelectedEmployee];
                fullNameTextBox.Text = _currentEmployee.FullName.ToString();
                postTextBox.Text = _currentEmployee.Post.ToString();
                dateTimePicker.Value = _currentEmployee.DateOfEmployment;
                salaryTextBox.Text = _currentEmployee.Salary.ToString();
            }
        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedIndex == -1)
                return;
            try
            {
                string employeeCurrentFullName = fullNameTextBox.Text;
                string employeeFullName = employeeCurrentFullName;
                _currentEmployee.FullName = employeeFullName;
                int index = IndexById();
                UpdateEmployeeInfo(index);
            }
            catch
            {
                fullNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            fullNameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void postTextBox_TextChanged(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedIndex == -1)
                return;
            try
            {
                string employeeCurrentPost = postTextBox.Text;
                string employeePost = employeeCurrentPost;
                _currentEmployee.Post = employeePost;
            }
            catch
            {
                postTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            postTextBox.BackColor = AppColors.CorrectColor;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker.MaxDate = DateTime.Now; 
            if (listBoxEmployees.SelectedIndex == -1)
                return;
            try
            {
                string employeeCurrentDate = dateTimePicker.Text;
                DateTime employeeDate = DateTime.Parse(employeeCurrentDate);
                _currentEmployee.DateOfEmployment = employeeDate;
            }
            catch
            {
                dateTimePicker.CalendarForeColor = AppColors.ErrorColor;
                return;
            }
            dateTimePicker.CalendarTitleBackColor = AppColors.CorrectColor;
        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedIndex == -1)
                return;
            try
            {
                string employeeCurrentSalary = salaryTextBox.Text;
                int employeeSalary = int.Parse(employeeCurrentSalary);
                _currentEmployee.Salary = employeeSalary;
            }
            catch
            {
                salaryTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            salaryTextBox.BackColor = AppColors.CorrectColor;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            int index = listBoxEmployees.SelectedIndex;
            if(index != -1)
            {
                _employees.RemoveAt(index);
                listBoxEmployees.Items.RemoveAt(index);
                ClearEmployeeInfo();

                for (int i = 0; i < _employees.Count; i++)
                {
                    listBoxEmployees.Items.Add(_employees[i].FullName);
                    listBoxEmployees.SelectedIndex = 0;
                }
            }
            UpdateEmployeeInfo(-1);
        }
    }
}
