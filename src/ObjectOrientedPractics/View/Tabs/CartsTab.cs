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
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Enums;
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

        private void UpdateDiscountDigit()
        {
            double discountAmount = 0;
            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    discountAmount += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                }
            }
            DiscountAmountDigitLabel.Text = discountAmount.ToString();
            if (CurrentCustomer.Cart.Amount == 0)
            {
                TotalDigitLabel.Text = CurrentCustomer.Cart.Amount.ToString();
                return;
            }
            TotalDigitLabel.Text = (CurrentCustomer.Cart.Amount - discountAmount).ToString();
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
            UpdateDiscountDigit();
        }

        private void UpdateItemInfo(int selectedIndex)
        {
            ListBoxItems.Items.Clear();

            _items = Sorting.SortedItems(_items);

            foreach (Item item in _items)
            {
                ListBoxItems.Items.Add(InitialConstants.ItemString(item));
            }

            //if (selectedIndex == -1) return;

            ListBoxItems.SelectedIndex = selectedIndex;
        }

        private void UpdateDiscountCheckedListBox()
        {
            DiscountCheckedListBox.Items.Clear();
            foreach (var discount in CurrentCustomer.Discounts)
            {
                DiscountCheckedListBox.Items.Add(discount.Info, true);
            }
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
            UpdateDiscountCheckedListBox();
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
            UpdateDiscountDigit();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int indexComboBox = CustomerComboBox.SelectedIndex;
            int indexListBox = ListBoxCarts.SelectedIndex;

            if (indexListBox == -1 || indexComboBox == -1) return;

            CurrentCustomer.Cart.Items.RemoveAt(indexListBox);
            LabelAmount.Text = CurrentCustomer.Cart.Amount.ToString();

            UpdateCartInfo(-1);
            UpdateDiscountDigit();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Cart = new Cart();
            UpdateCartInfo(-1);
            LabelAmount.Text = CurrentCustomer.Cart.Amount.ToString();
            UpdateDiscountDigit();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Order order;
            if (CurrentCustomer.IsPriority)
            {
                order = new PriorityOrder();
            }
            else
            {
                order = new Order();
            }

            order.Address = CurrentCustomer.Address;
            order.Items = CurrentCustomer.Cart.Items;
            order.Status = OrderStatus.New;
            double discountAmount = 0;
            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    discountAmount += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                }
            }
            order.DiscountAmount = discountAmount;
            CurrentCustomer.Orders.Add(order);

            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    CurrentCustomer.Discounts[i].Apply(CurrentCustomer.Cart.Items);
                }
                CurrentCustomer.Discounts[i].Update(CurrentCustomer.Cart.Items);
            }
            UpdateDiscountCheckedListBox();

            CurrentCustomer.Cart = new Cart();
            UpdateCartInfo(-1);
            LabelAmount.Text = CurrentCustomer.Cart.Amount.ToString();
            CreateOrderButton.Enabled = false;
        }

        private void DiscountCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscountDigit();
        }
    }
}
