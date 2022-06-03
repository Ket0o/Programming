using ListOfEmployees.Model.Classes;
using ListOfEmployees.Model.Employees;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListOfEmployees.View
{
    /// <summary>
    /// Предоставляет реализацию расположения элементов на форме.
    /// </summary>
    public partial class MainForm : Form
    {

        private string AppDataPath = Application.UserAppDataPath;

        /// <summary>
        /// Коллекция рабочих.
        /// </summary>
        private List<Employee> _employees;

        /// <summary>
        /// Выбранный рабочий.
        /// </summary>
        private Employee _currentEmployee;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _employees = ProjectSerializer.Deserialize(AppDataPath);

            foreach (Employee employee in _employees)
            {
                ListBoxEmployees.Items.Add($"{employee.FullName}");
            }
        }

        /// <summary>
        /// Наход индекс элемента по его уникальному индефикатору.
        /// </summary>
        /// <returns>Индекс.</returns>
        private int IndexById()
        {
            _employees = Sorting.SortedEmployees(_employees);

            int currentEmployeeId = _currentEmployee.Id;

            int index = -1;

            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Id == currentEmployeeId)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        /// <summary>
        /// Очищает информацию с текстовых полей и поля с датой.
        /// </summary>
        private void ClearEmployeeInfo()
        {
            FullNameTextBox.Clear();
            PostTextBox.Clear();
            SalaryTextBox.Clear();
            DateTimePicker.Value = new DateTime(1753, 1, 1);
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="selectedIndex">Выбранный индекс.</param>
        private void UpdateEmployeeInfo(int selectedIndex)
        {
            ListBoxEmployees.Items.Clear();

            _employees = Sorting.SortedEmployees(_employees);

            foreach (Employee employee in _employees)
            {
                ListBoxEmployees.Items.Add($"{employee.FullName}");
            }

            if (selectedIndex == -1) return;

            ListBoxEmployees.SelectedIndex = selectedIndex;
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            _currentEmployee = EmployeeFactory.CreateStandart();
            _employees.Add(_currentEmployee);
            ListBoxEmployees.Items.Add(_currentEmployee.FullName);
        }

        private void ListBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxEmployees.SelectedItem != null)
            {
                int indexSelectedEmployee = ListBoxEmployees.SelectedIndex;
                _currentEmployee = _employees[indexSelectedEmployee];
                FullNameTextBox.Text = _currentEmployee.FullName.ToString();
                PostTextBox.Text = _currentEmployee.Post.ToString();
                DateTimePicker.Value = _currentEmployee.DateOfEmployment;
                SalaryTextBox.Text = _currentEmployee.Salary.ToString();
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxEmployees.SelectedIndex == -1)
                return;

            try
            {
                string employeeCurrentFullName = FullNameTextBox.Text;
                _currentEmployee.FullName = employeeCurrentFullName;
                int index = IndexById();
                UpdateEmployeeInfo(index);
                ProjectSerializer.Serialize(AppDataPath, _employees);
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            FullNameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void PostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxEmployees.SelectedIndex == -1)
                return;

            try
            {
                string employeeCurrentPost = PostTextBox.Text;
                _currentEmployee.Post = employeeCurrentPost;
                ProjectSerializer.Serialize(AppDataPath, _employees);
            }
            catch
            {
                PostTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            PostTextBox.BackColor = AppColors.CorrectColor;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker.MaxDate = DateTime.Now;
            if (ListBoxEmployees.SelectedIndex == -1)
                return;

            try
            {
                string employeeCurrentDate = DateTimePicker.Text;
                _currentEmployee.DateOfEmployment = DateTime.Parse(employeeCurrentDate);
                ProjectSerializer.Serialize(AppDataPath, _employees);
            }
            catch
            {
                DateTimePicker.CalendarForeColor = AppColors.ErrorColor;
                return;
            }

            DateTimePicker.CalendarTitleBackColor = AppColors.CorrectColor;
        }

        private void SalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxEmployees.SelectedIndex == -1)
                return;

            try
            {
                string employeeCurrentSalary = SalaryTextBox.Text;
                _currentEmployee.Salary = int.Parse(employeeCurrentSalary);
                ProjectSerializer.Serialize(AppDataPath, _employees);
            }
            catch
            {
                SalaryTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            SalaryTextBox.BackColor = AppColors.CorrectColor;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = ListBoxEmployees.SelectedIndex;

            if (index != -1)
            {
                _employees.RemoveAt(index);
                ListBoxEmployees.Items.RemoveAt(index);
                ClearEmployeeInfo();

                for (int i = 0; i < _employees.Count; i++)
                {
                    ListBoxEmployees.Items.Add(_employees[i].FullName);
                    ListBoxEmployees.SelectedIndex = 0;
                }
            }

            UpdateEmployeeInfo(-1);
            ProjectSerializer.Serialize(AppDataPath, _employees);
        }

        private void PlusButton_MouseEnter(object sender, EventArgs e)
        {
            PlusButton.Image = Properties.Resources.plus_24x24;
        }

        private void PlusButton_MouseLeave(object sender, EventArgs e)
        {
            PlusButton.Image = Properties.Resources.plus_24x24_uncolor;
        }

        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteButton.Image = Properties.Resources.minus_24x24;
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.Image = Properties.Resources.minus_24x24_uncolor;
        }
    }
}
