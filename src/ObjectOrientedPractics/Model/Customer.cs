using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        private static int _allCustomersCount;

        private int _id;

        private string _fullName;

        private string _address;

        public static int AllCustomersCount
        {
            get => _allCustomersCount;
        }

        public string FullName
        {
            get => (_fullName == null) ? null : _fullName;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthName, FullName);
                _fullName = value;
            }
        }

        public string Address
        {
            get => (_address == null) ? null : _address;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthAddress, Address);
                _address = value;
            }
        }

        public int Id
        {
            get => _id;
        }

        public Customer()
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
        }

        public Customer(int id, string fullName, string address)
        {
            FullName = fullName;
            Address = address;
            _allCustomersCount++;
            _id = _allCustomersCount;
        }
    }
}
