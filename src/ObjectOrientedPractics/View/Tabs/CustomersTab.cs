using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using Customer = ObjectOrientedPractics.Model.Customer;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers;

        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();

            _customers = new List<Customer>();
        }

        private string FormatCustomer(Customer customer)
        {
            string lineOutputCustomer = $"{customer.Id}: " +
                                    $"(FullName= {customer.FullName});";
            return lineOutputCustomer;
        }

        private void ClearCustomerInfo()
        {
            ListBoxCustomers.Items.Clear();
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            AddressTextBox.Clear();
        }

        private void UpdateItemInfo(Customer customer)
        {
            int ind = ListBoxCustomers.FindString(customer.Id.ToString());

            if (ind == -1) return;

            ListBoxCustomers.Items[ind] = FormatCustomer(customer);
        }

        private void ListBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxCustomers.SelectedItem != null)
            {
                int indexSelectedCustomer = ListBoxCustomers.SelectedIndex;
                _currentCustomer = _customers[indexSelectedCustomer];
                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                AddressTextBox.Text = _currentCustomer.Address;
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxCustomers.SelectedIndex == -1)
                return;
            try
            {
                string customerCurrentFullName = FullNameTextBox.Text;
                _currentCustomer.FullName = customerCurrentFullName;
                UpdateItemInfo(_currentCustomer);
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            FullNameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxCustomers.SelectedIndex == -1)
                return;
            try
            {
                string customerCurrentAddress = AddressTextBox.Text;
                _currentCustomer.Address = customerCurrentAddress;
                UpdateItemInfo(_currentCustomer);
            }
            catch
            {
                AddressTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            AddressTextBox.BackColor = AppColors.CorrectColor;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = CustomerFactory.DefaultCustomer();
            _customers.Add(_currentCustomer);
            ListBoxCustomers.Items.Add(FormatCustomer(_currentCustomer));
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
                    ListBoxCustomers.Items.Add(FormatCustomer(_customers[i]));
                    ListBoxCustomers.SelectedIndex = 0;
                }
            }
        }
    }
}
