using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс реализует сериализцаию и десериализацию данных.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Путь к a AppData
        /// </summary>
        private static string AppDataPath = Application.UserAppDataPath;

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="items">Коллекция класса <see cref="Item"/></param>
        public static void Serialize(List<Item> items)
        {
            using (StreamWriter sw = new StreamWriter(AppDataPath + InitialConstants.SerializerResultItems))
            {
                sw.Write(JsonConvert.SerializeObject(items));
            }
        }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="customers">Коллекция класса<see cref="Customer"/> /param>
        public static void Serialize(List<Customer> customers)
        {
            using (StreamWriter sw = new StreamWriter(AppDataPath + InitialConstants.SerializerResultCustomers))
            {
                sw.Write(JsonConvert.SerializeObject(customers));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию продуктов.</returns>
        public static List<Item> DeserializeItems()
        {
            var items = new List<Item>();

            try
            {
                using (StreamReader sr = new StreamReader(AppDataPath + InitialConstants.SerializerResultItems))
                {
                    items = JsonConvert.DeserializeObject<List<Item>>(sr.ReadToEnd());
                }

                if (items == null)
                {
                    items = new List<Item>();
                }
            }
            catch
            {
                return items;
            }

            return items;
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию покупателей.</returns>
        public static List<Customer> DeserializeCustomers()
        {
            var customers = new List<Customer>();

            try
            {
                using (StreamReader sr = new StreamReader(AppDataPath + InitialConstants.SerializerResultCustomers))
                {
                    customers = JsonConvert.DeserializeObject<List<Customer>>(sr.ReadToEnd());
                }

                if (customers == null)
                {
                    customers = new List<Customer>();
                }
            }
            catch
            {
                return customers;
            }

            return customers;
        }
    }
}
