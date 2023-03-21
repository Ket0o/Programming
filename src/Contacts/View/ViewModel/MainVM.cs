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
        //private SaveCommand _saveCommand;

        //private LoadCommand _loadCommand;

        public Contact Contact { get; set; } = new Contact();

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

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void Save()
        {
            ContactSerializer.Serialize(Contact);
        }

        public void Load()
        {
            Contact contact = ContactSerializer.Deserialize();
            Name = contact.Name;
            PhoneNumber = contact.PhoneNumber;
            Email = contact.Email;
        }

        public ICommand SaveCommand
        {
            get
            {
                return new SaveCommand(this);
            }
        }

        public ICommand LoadCommand
        {
            get
            {
                return new LoadCommand(this);
            }
        }

        //public MainVM()
        //{
        //    _saveCommand = new SaveCommand(this);
        //    _loadCommand = new LoadCommand(this);
        //}
    }
}