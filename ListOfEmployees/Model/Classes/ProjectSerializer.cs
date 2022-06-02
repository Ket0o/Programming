using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ListOfEmployees.Model.Employees;
using Newtonsoft.Json;


namespace ListOfEmployees.Model.Classes
{
    /// <summary>
    /// Класс реализует сериализцаию и десериализацию данных.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="employees">Коллекция класса <see cref="Employee"/></param>
        public static void Serialize(string path ,List<Employee> employees)
        {
            using (StreamWriter sw = new StreamWriter(path + @"Serializer.json"))
            {
                sw.Write(JsonConvert.SerializeObject(employees));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию работников.</returns>
        public static List<Employee> Deserialize(string path)
        {
            var employees = new List<Employee>();

            try
            {
                using (StreamReader sr = new StreamReader(path + @"Serializer.json"))
                {
                    employees = JsonConvert.DeserializeObject<List<Employee>>(sr.ReadToEnd());
                }

                if (employees == null)
                {
                    employees = new List<Employee>();
                }
            }
            catch
            {
                return employees;
            }

            return employees;
        }
    }
}
