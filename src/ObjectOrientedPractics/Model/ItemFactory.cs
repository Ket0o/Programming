using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public static class ItemFactory
    {
        public static Item DefaultItem()
        {
            Item item = new Item();
            item.Name = "Name";
            item.Cost = 0;
            item.Info = "Description";
            return item;
        }
    }
}
