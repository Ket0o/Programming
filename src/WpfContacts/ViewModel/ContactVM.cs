using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfContacts.Infastructure.Commands;
using WpfContacts.Model;

namespace WpfContacts.ViewModel
{
    public class ContactVM : Base.ViewModel
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
        public long PhoneNumber
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
    }
}
