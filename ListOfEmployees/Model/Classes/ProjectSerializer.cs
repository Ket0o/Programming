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
    public class ProjectSerializer
    {
        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="employees">Коллекция класса <see cref="Employee"/></param>
        public static void Serialize(List<Employee> employees)
        {
            using (StreamWriter sw = new StreamWriter(@"Serializer.json"))
            {
                sw.Write(JsonConvert.SerializeObject(employees));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию работников.</returns>
        public static List<Employee> Deserialize()
        {
            var employees = new List<Employee>();

            using(StreamReader sr = new StreamReader(@"Serializer.json"))
            {
                employees = JsonConvert.DeserializeObject<List<Employee>>(sr.ReadToEnd());
                if(employees == null)
                {
                    employees = new List<Employee>();
                }
            }

            return employees;
        }
    }
}
