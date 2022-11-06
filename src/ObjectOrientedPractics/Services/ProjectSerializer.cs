﻿using Newtonsoft.Json;
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
                writer.Write(JsonConvert.SerializeObject(store));
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
                    store = JsonConvert.DeserializeObject<Store>(reader.ReadToEnd());
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