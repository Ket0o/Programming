using System;
using System.Collections.Generic;
using ListOfEmployees.Model.Employees;
using ListOfEmployees.Model.Classes;
using System.Windows.Forms;
using System.Linq;

namespace ListOfEmployees.View
{
    public partial class Employees : Form
    {
        private List<Employee> _employees;

        private Employee _currentEmployee;

        private string AppdataPath = Application.UserAppDataPath;

        public Employees()
        {
            InitializeComponent();

            _employees = ProjectSerializer.Deserialize();

            foreach (Employee employee in _employees)
            {
                listBoxEmployees.Items.Add($"{employee.FullName}");
            }
        }

        private int IndexById ()
        {
            _employees = Sorting.SortedEmployees(_employees);


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
            fullNameTextBox.Clear();
            postTextBox.Clear();
            salaryTextBox.Clear();
            dateTimePicker.Value = new DateTime(1753, 1, 1);
        }

        private void UpdateEmployeeInfo(int selectedIndex)
        {
            listBoxEmployees.Items.Clear();

            _employees = Sorting.SortedEmployees(_employees);

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
                ProjectSerializer.Serialize(_employees);
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
                ProjectSerializer.Serialize(_employees);
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
                ProjectSerializer.Serialize(_employees);
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
                ProjectSerializer.Serialize(_employees);
            }
            catch
            {
                salaryTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            salaryTextBox.BackColor = AppColors.CorrectColor;
        }

        private void deleteButton_Click(object sender, EventArgs e)
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
            ProjectSerializer.Serialize(_employees);
        }

        private void plusButton_MouseEnter(object sender, EventArgs e)
        {
            plusButton.Image = Properties.Resources.plusColor;
        }

        private void plusButton_MouseLeave(object sender, EventArgs e)
        {
            plusButton.Image = Properties.Resources.plusUncolor;
        }

        private void deleteButton_MouseEnter(object sender, EventArgs e)
        {
            deleteButton.Image = Properties.Resources.minusColor;
        }

        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.Image = Properties.Resources.minusUncolor;
        }
    }
}
