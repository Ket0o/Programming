using System;
using System.ComponentModel;
using WpfContacts.Model;

namespace WpfContacts.ViewModel
{
    /// <summary>
    /// ViewModel для contact.
    /// </summary>
    public class ContactVM : Base.ViewModel, IDataErrorInfo
    {
        /// <summary>
        /// Контактные данные.
        /// </summary>
        public Contact Contact { get; } = new Contact();

        /// <summary>
        /// Возвращает и задает имя.
        /// </summary>
        public string Name
        {
            get => Contact.Name;
            set
            {
                Contact.Name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает телефонный номер.
        /// </summary>
        public string PhoneNumber
        {
            get => Contact.PhoneNumber;
            set
            {
                Contact.PhoneNumber = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту.
        /// </summary>
        public string Email
        {
            get => Contact.Email;
            set
            {
                Contact.Email = value;
                OnPropertyChanged();
            }
        }

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Name":
                        if (Name == null)
                        {
                            break;
                        }
                        if (Name.Length > 100)
                        {
                            error = "Name должен быть не длиннее 100 символов";
                        }
                        break;
                    case "PhoneNumber":
                        if (PhoneNumber == null)
                        {
                            break;
                        }

                        if (PhoneNumber.Length > 100)
                        {
                            error =
                                "PhoneNumber должен быть не длиннее 100 символов и " +
                                "может содержать только цифры или символы +-() .\r\nПример: " +
                                "+7 (999) 111-22-33\r\n";
                        }
                        break;
                }
                return error;
            }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }
    }
}
