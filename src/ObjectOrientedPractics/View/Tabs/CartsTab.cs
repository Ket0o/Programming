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
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private List<Item> _items;

        private List<Customer> _customers;

        public CartsTab()
        {
            InitializeComponent();
        }

        private Customer CurrentCustomer { get; set; }

        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;

                if (_items != null)
                {
                    UpdateItemInfo(-1);
                }
            }
        }

        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;

                if (_customers != null)
                {
                    foreach (var customer in _customers)
                    {
                        CustomerComboBox.Items.Add(customer.FullName);
                    }
                }
            }
        }

        public void RefreshData()
        {
            UpdateItemInfo(-1);

            CustomerComboBox.Items.Clear();
            foreach (var customer in _customers)
            {
                CustomerComboBox.Items.Add(customer.FullName);
            }

            if (CustomerComboBox.Items.Count > 0)
            {
                CustomerComboBox.SelectedIndex = 0;
            }
            else
            {
                CustomerComboBox.SelectedItem = -1;
            }
        }

        private void UpdateItemInfo(int selectedIndex)
        {
            ListBoxItems.Items.Clear();

            _items = Sorting.SortedItems(_items);

            foreach (Item item in _items)
            {
                ListBoxItems.Items.Add(InitialConstants.ItemString(item));
            }

            if (selectedIndex == -1) return;

            ListBoxItems.SelectedIndex = selectedIndex;
        }

        private void UpdateCartInfo(int selectedIndex)
        {
            ListBoxCarts.Items.Clear();

            CurrentCustomer.Cart.Items = Sorting.SortedItems(CurrentCustomer.Cart.Items);

            foreach (var item in CurrentCustomer.Cart.Items)
            {
                ListBoxCarts.Items.Add(InitialConstants.ItemString(item));
            }

            ListBoxCarts.SelectedIndex = selectedIndex;

            CreateOrderButton.Enabled = false;
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomerComboBox.SelectedIndex;

            if (index == -1) return;

            CurrentCustomer = _customers[index];

            if (CurrentCustomer.Cart.Items == null) return;

            LabelAmount.Text = CurrentCustomer.Cart.Amount.ToString();
            UpdateCartInfo(-1);
        }

        private void AddCartButton_Click(object sender, EventArgs e)
        {
            int indexListBox = ListBoxItems.SelectedIndex;
            int indexComboBox = CustomerComboBox.SelectedIndex;

            if (indexListBox == -1 || indexComboBox == -1) return;

            CurrentCustomer.Cart.Items.Add(_items[indexListBox]);

            LabelAmount.Text = CurrentCustomer.Cart.Amount.ToString();

            UpdateCartInfo(-1);
            CreateOrderButton.Enabled = true;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int indexComboBox = CustomerComboBox.SelectedIndex;
            int indexListBox = ListBoxCarts.SelectedIndex;

            if (indexListBox == -1 || indexComboBox == -1) return;

            CurrentCustomer.Cart.Items.RemoveAt(indexListBox);
            LabelAmount.Text = CurrentCustomer.Cart.Amount.ToString();

            UpdateCartInfo(-1);
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Cart = new Cart();
            UpdateCartInfo(-1);
            LabelAmount.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Address = CurrentCustomer.Address;
            order.Items = CurrentCustomer.Cart.Items;
            //TODO:order.Status = OrderStatus.New;
            CurrentCustomer.Orders.Add(order);
            CurrentCustomer.Cart = new Cart();
            UpdateCartInfo(-1);
            LabelAmount.Text = CurrentCustomer.Cart.Amount.ToString();
            CreateOrderButton.Enabled = false;
        }
    }
}
