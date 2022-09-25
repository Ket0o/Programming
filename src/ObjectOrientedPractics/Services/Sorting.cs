using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public static class Sorting
    {
        public static List<Item> SortedItems(List<Item> items)
        {
            var sortedListItems = from item in items
                orderby item.Name
                select item;

            return sortedListItems.ToList();
        }
        
        public static List<Customer> SortedCustomers(List<Customer> customers)
        {
            var sortedListCostumer = from customer in customers
                orderby customer.FullName
                select customer;

            return sortedListCostumer.ToList();
        }
    }
}
