using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        private List<Order> _orders;

        private Order _currentOrder;

        public OrdersTab()
        {
            InitializeComponent();

            _orders = new List<Order>();

            var orderStatusValues = Enum.GetValues(typeof(OrderStatus));

            foreach (var value in orderStatusValues)
            {
                StatusComboBox.Items.Add(value);
            }

            StatusComboBox.Enabled = false;
        }

        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;

                if (_customers != null)
                {
                    UpdateOrderInfo();
                }
            }
        }

        public void RefreshData()
        {
            OrdersDataGridView.Rows.Clear();
            _orders = new List<Order>();
            UpdateOrderInfo();
        }

        private void UpdateOrderInfo()
        {
            foreach (var customer in _customers)
            {
                Address address = customer.Address;
                string fullAddress = $"{address.Index}, {address.Country}, {address.City}," +
                                     $" {address.Street}, {address.Building}, {address.Apartment}";

                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                    OrdersDataGridView.Rows.Add(order.Id.ToString(), order.CreatesDate,
                        order.Status, customer.FullName, fullAddress, order.Amount.ToString());
                }
            }
        }

        private void SetValuesTextBoxes()
        {
            StatusComboBox.Enabled = true;
            IdTextBox.Text = _currentOrder.Id.ToString();
            CreatedTextBox.Text = _currentOrder.CreatesDate;
            StatusComboBox.SelectedIndex = (int)_currentOrder.Status;
            AddressControl.Address = _currentOrder.Address;

            OrderItemsListBox.Items.Clear();
            foreach (var item in _currentOrder.Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }

            LabelAmount.Text = _currentOrder.Amount.ToString();
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int index = OrdersDataGridView.CurrentCell.RowIndex;
            if (index == -1) return;

            _currentOrder = _orders[index];
            SetValuesTextBoxes();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = OrdersDataGridView.CurrentCell.RowIndex;

            _currentOrder.Status = (OrderStatus)StatusComboBox.SelectedIndex;
            OrdersDataGridView.Rows[index].Cells[2].Value = (OrderStatus)StatusComboBox.SelectedIndex;
        }
    }
}
