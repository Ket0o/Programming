using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    public static class ContactSerializer
    {
        public static string AppDataPath { get; set; } =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\Contacts\contacts.json";

        public static void Serialize(Contact contact)
        {
            using (StreamWriter writer = 
                   new StreamWriter(AppDataPath))
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.All;
                writer.Write(JsonConvert.SerializeObject(contact, settings));                        
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Объект типа <see cref="Store"/>.</returns>
        public static Contact Deserialize()
        {
            var contact = new Contact();

            try
            {
                using (StreamReader reader = 
                       new StreamReader(AppDataPath))
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings();
                    settings.TypeNameHandling = TypeNameHandling.All;
                    contact = JsonConvert.DeserializeObject<Contact>(reader.ReadToEnd(), 
                        settings);
                }

                if (contact == null) contact = new Contact();
            }
            catch
            {
                return contact;
            }

            return contact;
        }
    }
}
