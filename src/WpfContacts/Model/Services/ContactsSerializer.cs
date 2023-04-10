using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;
using WpfContacts.ViewModel;

namespace WpfContacts.Model.Services
{
    public static class ContactsSerializer
    {
        /// <summary>
        /// Путь к – «Мои документы\Contacts\contacts.json».
        /// </summary>
        public static string MyDocumentsPath { get; set; } =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\Contacts\contacts.json";

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="contact">Контактные данные.</param>
        public static void Serialize(ObservableCollection<ContactVM>? contact)
        {
            if (!Directory.Exists(Path.GetDirectoryName(MyDocumentsPath)))
                Directory.CreateDirectory(
                    Path.GetDirectoryName(MyDocumentsPath));
            using (StreamWriter writer = new StreamWriter(MyDocumentsPath))
            {
                writer.Write(JsonConvert.SerializeObject(contact));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Объект типа <see cref="Contact"/>.</returns>
        public static ObservableCollection<ContactVM>? Deserialize()
        {
            if (!Directory.Exists(Path.GetDirectoryName(MyDocumentsPath)))
                Directory.CreateDirectory(Path.GetDirectoryName(MyDocumentsPath));
            ObservableCollection<ContactVM>? contact = new ObservableCollection<ContactVM>();
            try
            {
                using (StreamReader reader = new StreamReader(MyDocumentsPath))
                {
                    contact = JsonConvert.
                        DeserializeObject<ObservableCollection<ContactVM>>(reader.ReadToEnd());
                }

                if (contact == null) contact = new ObservableCollection<ContactVM>();
            }
            catch (FileNotFoundException e)
            {
                return contact;
            }

            return contact;
        }
    }
}
