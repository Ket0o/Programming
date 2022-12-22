﻿using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.View.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Customer = ObjectOrientedPractics.Model.Customer;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Реализация по представлению покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();

            IsPriorityCheckBox.Enabled = true;
        }

        /// <summary>
        /// Возвращает и задает коллекцию покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;

                if (_customers != null)
                {
                    UpdateCustomerInfo(-1);
                }
            }
        }

        private void UpdateDiscountsListBox()
        {
            DiscountsListBox.Items.Clear();

            foreach (var discount in _currentCustomer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        /// <summary>
        /// Очищает информацию с текстовых полей.
        /// </summary>
        private void ClearCustomerInfo()
        {
            ListBoxCustomers.Items.Clear();
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            AddressControl.ClearInfo();
            DiscountsListBox.Items.Clear();
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="selectedIndex">Выбранный индекс.</param>
        private void UpdateCustomerInfo(int selectedIndex)
        {
            ListBoxCustomers.Items.Clear();

            _customers = Sorting.SortedCustomers(_customers);

            foreach (Customer customer in _customers)
            {
                ListBoxCustomers.Items.Add($"{customer.Id}: " + $"{customer.FullName};");
            }

            ListBoxCustomers.SelectedIndex = selectedIndex;
        }



        private void ListBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxCustomers.SelectedItem != null)
            {
                int indexSelectedCustomer = ListBoxCustomers.SelectedIndex;
                _currentCustomer = _customers[indexSelectedCustomer];
                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                AddressControl.Address = _currentCustomer.Address;
            }
            UpdateDiscountsListBox();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxCustomers.SelectedIndex == -1)
                return;
            try
            {
                string customerCurrentFullName = FullNameTextBox.Text;
                _currentCustomer.FullName = customerCurrentFullName;
                int index = _customers.IndexOf(_currentCustomer);
                UpdateCustomerInfo(index);
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            FullNameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = CustomerFactory.DefaultCustomer();
            _customers.Add(_currentCustomer);
            int index = _customers.IndexOf(_currentCustomer);
            Sorting.SortedCustomers(_customers);
            UpdateCustomerInfo(index);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ListBoxCustomers.SelectedIndex;
            if (index != -1)
            {
                _customers.RemoveAt(index);
                ListBoxCustomers.Items.RemoveAt(index);
                ClearCustomerInfo();

                for (int i = 0; i < _customers.Count; i++)
                {
                    ListBoxCustomers.Items.Add(_customers[i].FullName);
                    ListBoxCustomers.SelectedIndex = 0;
                }
            }

            UpdateCustomerInfo(-1);
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _currentCustomer.IsPriority = IsPriorityCheckBox.Checked;
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            AddDiscountForm addDiscountForm = new AddDiscountForm();
            if (addDiscountForm.ShowDialog() == DialogResult.OK)
            {
                foreach (var discount in _currentCustomer.Discounts)
                {
                    if (discount is PointsDiscount) continue;
                    if (((PercentDiscount)discount).Category ==
                        addDiscountForm.PercentDiscount.Category) return;
                }
                _currentCustomer.Discounts.Add(addDiscountForm.PercentDiscount);
                UpdateDiscountsListBox();
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            int index = DiscountsListBox.SelectedIndex;
            if (index == -1) return;
            if (index == 0) return;
            _currentCustomer.Discounts.RemoveAt(index);
            UpdateDiscountsListBox();
        }
    }
}