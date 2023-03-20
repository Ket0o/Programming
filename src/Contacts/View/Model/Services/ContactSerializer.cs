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
            using (StreamWriter writer = new StreamWriter(AppDataPath + InitialConstants.SerializerResultStore))
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.All;
                writer.Write(JsonConvert.SerializeObject(store, settings));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Объект типа <see cref="Store"/>.</returns>
        public static Store Deserialize()
        {
            var store = new Store();

            try
            {
                using (StreamReader reader = new StreamReader(AppDataPath + InitialConstants.SerializerResultStore))
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings();
                    settings.TypeNameHandling = TypeNameHandling.All;
                    store = JsonConvert.DeserializeObject<Store>(reader.ReadToEnd(), settings);
                }

                if (store == null) store = new Store();
            }
            catch
            {
                return store;
            }

            return store;
        }
    }
}
