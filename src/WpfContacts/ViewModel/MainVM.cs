using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfContacts.Infastructure.Commands;
using WpfContacts.Model;

namespace WpfContacts.ViewModel
{
    public class MainVM : Base.ViewModel
    {
        private ContactVM _selectedContact;

        private void OnAddContactCommandExecute(object parameter)
        {
            ContactVM contact = new ContactVM();
            Contacts.Add(contact);
        }

        private bool CanAddContactCommandExecute(object parameter)
        {
            return true;
        }

        private void OnEditContactCommandExecute(object parameter)
        {
            IsReadOnly = false;
        }

        private bool CanEditContactCommandExecute(object parameter)
        {
            return true;
        }

        public bool IsReadOnly { get; private set; } = true;

        public bool IsEnabled { get; private set; } = true;

        public bool Visibility { get; private set; } = true;

        public ICommand AddContactCommand { get; }

        public ICommand EditContactCommand { get; }

        public ObservableCollection<ContactVM> Contacts { get; } = 
            new ObservableCollection<ContactVM>();

        public MainVM()
        {
            AddContactCommand = new RelayCommand(OnAddContactCommandExecute,
                CanAddContactCommandExecute);
        }

        public ContactVM SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }
    }
}
