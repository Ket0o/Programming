using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        private static int _allOrdersCount;

        private readonly int _id;

        private readonly string _createsDate;

        private Address _address;

        private List<Item> _items;

        private double _amount;

        public int Id
        {
            get { return _id; }
        }

        public string CreatesDate
        {
            get { return _createsDate; }
        }

        private Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public double Amount
        {
            get
            {
                _amount = 0;

                if (_items == null)
                {
                    return _amount;
                }

                foreach (var item in Items)
                {
                    _amount += item.Cost;
                }

                return _amount;
            }
        }

        public Order()
        {
            _allOrdersCount++;
            _id = _allOrdersCount;
            _createsDate = DateTime.Today.ToString();
        }
    }
}