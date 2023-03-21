using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        public Contact Contact { get; set; } = new Contact();

        public string Name
        {
            get => Contact.Name;
            set
            {
                Contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int PhoneNumber
        {
            get => Contact.PhoneNumber;
            set
            {
                Contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        public string Email
        {
            get => Contact.Email;
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    ContactSerializer.Serialize(Contact);
                });
            }
        }

        public ICommand LoadCommand
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    Contact contact = ContactSerializer.Deserialize();
                    Name = contact.Name;
                    PhoneNumber = contact.PhoneNumber;
                    Email = contact.Email;
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}