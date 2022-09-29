using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс создает шаблон для заполнения информации о продукте.
    /// </summary>
    public static class ItemFactory
    {
        /// <summary>
        /// Создание шаблона для заполнения информации о продукте.
        /// </summary>
        /// <returns>Шаблон для заполнения информации о продукте.</returns>
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
