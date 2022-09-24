using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public static class CustomerFactory
    {
        public static Customer DefaultCustomer()
        {
            Customer customer = new Customer();
            customer.FullName = "Full name";
            customer.Address = "Address";
            return customer;
        }
    }
}