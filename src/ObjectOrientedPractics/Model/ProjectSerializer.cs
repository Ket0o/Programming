using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Model
{
    public static class ProjectSerializer
    {
        /// <summary>
        /// Путь к a AppData
        /// </summary>
        private static string AppDataPath = Application.UserAppDataPath;

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="employees">Коллекция класса <see cref="Employee"/></param>
        public static void Serialize(List<Item> items)
        {
            using (StreamWriter sw = new StreamWriter(AppDataPath + InitialConstants.SerializerResult))
            {
                sw.Write(JsonConvert.SerializeObject(items));
            }
        }
        
        public static void Serialize(List<Customer> customers)
        {
            using (StreamWriter sw = new StreamWriter(AppDataPath + InitialConstants.SerializerResult))
            {
                sw.Write(JsonConvert.SerializeObject(customers));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию работников.</returns>
        public static List<Item> DeserializeItems()
        {
            var items = new List<Item>();

            try
            {
                using (StreamReader sr = new StreamReader(AppDataPath + InitialConstants.SerializerResult))
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
        
        public static List<Customer> DeserializeCustomers()
        {
            var customers = new List<Customer>();

            try
            {
                using (StreamReader sr = new StreamReader(AppDataPath + InitialConstants.SerializerResult))
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
