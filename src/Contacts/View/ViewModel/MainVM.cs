using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Contact Contact { get; } = new Contact();

        public string Name
        {
            get => Contact.Name;
            set
            {
                Contact.Name = value;
                OnPropertyChanged();
            }
        }

        public int PhoneNumber
        {
            get => Contact.PhoneNumber;
            set
            {
                Contact.PhoneNumber = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => Contact.Email;
            set
            {
                Contact.Email = value;
                OnPropertyChanged();
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

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}