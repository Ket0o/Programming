﻿using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Предоставляет реализацию расположения элементов на форме.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Покупатели и товары.
        /// </summary>
        private Store _store;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _store = ProjectSerializer.Deserialize();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            //OrdersTab.Customers = _store.Customers;
            priorityOrdersTab1.Items = _store.Items;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _store.Items = ItemsTab.Items;
            _store.Customers = CustomersTab.Customers;
            ProjectSerializer.Serialize(_store);
        }

        private void TabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (TabControl.SelectedIndex == 2)
            {
                CartsTab.Items = ItemsTab.Items;
                CartsTab.Customers = CustomersTab.Customers;
                CartsTab.RefreshData();
            }
            else if (TabControl.SelectedIndex == 3)
            {
                //OrdersTab.Customers = CartsTab.Customers;
                //OrdersTab.RefreshData();
            }
        }
    }
}