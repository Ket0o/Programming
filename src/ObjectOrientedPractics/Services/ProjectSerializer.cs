using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using System.IO;
using System.Windows.Forms;

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
        /// <param name="store">Покупатели и товары.</param>
        public static void Serialize(Store store)
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