using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

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
            item.Cost = 10;
            item.Info = "Info";
            item.Category = Category.Meat;

            return item;
        }
    }
}
