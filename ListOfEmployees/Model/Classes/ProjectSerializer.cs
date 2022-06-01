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
    public class ProjectSerializer
    {
        public static void Serialize(List<Employee> employees)
        {
            using (StreamWriter sw = new StreamWriter(@"Serializer.json"))
            {
                sw.Write(JsonConvert.SerializeObject(employees));
            }
        }

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
