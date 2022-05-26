using System;
using System.Collections.Generic;
using ListOfEmployees.Model.Employees;
using ListOfEmployees.Model.Classes;
using System.Windows.Forms;

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
            Employee temp;

            for (int j = 0; j < _employees.Count; j++)
            {
                for (int i = 0; i < _employees.Count - 1; i++)
                {
                    string x_str = _employees[i].FullName;
                    string y_str = _employees[i + 1].FullName; ;
                    x_str = x_str.Substring(1); y_str = y_str.Substring(1);
                    int x = Convert.ToInt32(x_str); int y = Convert.ToInt32(y_str);

                    if (x > y)
                    {
                        temp = _employees[i];
                        _employees[i] = _employees[i + 1];
                        _employees[i + 1] = temp;
                    }
                }
            }

            return _employees;
        }

        private int IndexById ()
        {
            SortedEmployees(_employees);

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

        private string FormatEmployee(Employee employee)
        {
            string lineOutputEmployee = $"{employee.FullName}";
            return lineOutputEmployee;
        }

        private void ClearEmployeeInfo()
        {
            listBoxEmployees.Items.Clear();
            fullNameTextBox.Clear();
            postTextBox.Clear();
            salaryTextBox.Clear();
            dateTimePicker.Value = new DateTime(1753, 1, 1);
        }

        private void UpdateEmployeeInfo(int selectedIndex)
        {
            ClearEmployeeInfo();

            SortedEmployees(_employees);

            foreach(Employee employee in _employees)
            {
                listBoxEmployees.Items.Add($"{employee.FullName}");
            }

            if (selectedIndex == -1) return;

            listBoxEmployees.SelectedIndex = selectedIndex;
        }



        private void plusButton_Click(object sender, EventArgs e)
        {
            _currentEmployee = EmployeeFactory.Randomize();
            _employees.Add(_currentEmployee);
            listBoxEmployees.Items.Add(FormatEmployee(_currentEmployee));
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
                dateTimePicker.CalendarTitleBackColor = AppColors.ErrorColor;
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

                for(int i = 0; i < _employees.Count; i++)
                {
                    listBoxEmployees.Items.Add(FormatEmployee(_employees[i]));
                    listBoxEmployees.SelectedIndex = 0;
                }
            }
        }
    }
}
