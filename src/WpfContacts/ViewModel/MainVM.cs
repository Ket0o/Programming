using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfContacts.Infastructure.Commands;
using WpfContacts.Model;
using WpfContacts.Model.Services;


namespace WpfContacts.ViewModel
{
    public class MainVM : Base.ViewModel
    {
        private ContactVM _selectedContact;

        private void OnAddContactCommandExecute(object parameter)
        {
            SelectedContact = null;
            ContactVM contact = new ContactVM();
            SelectedContact = contact;
            OnProperties();
        }

        private bool CanAddContactCommandExecute(object parameter)
        {
            if (Visibility)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void OnEditContactCommandExecute(object parameter)
        {
            ContactsSerializer.Serialize(Contacts);
            OnProperties();
        }

        private bool CanEditContactCommandExecute(object parameter)
        {
            if (Visibility)
            {
                return false;
            }
            else if (SelectedContact != null)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private void OnDeleteContactCommandExecure(object parameter)
        {
            if (SelectedContact == Contacts.Last())
            {
                Contacts!.Remove(SelectedContact);
                if (Contacts.Count > 1)
                {
                    SelectedContact = Contacts.Last();
                }
                else
                {
                    SelectedContact = null;
                }
            }
            else
            {
                for (int i = 0; i < Contacts.Count; i++)
                {
                    if (SelectedContact == Contacts[i])
                    {
                        Contacts!.Remove(SelectedContact);
                        SelectedContact = Contacts[i];
                        break;
                    }
                }
            }

            ContactsSerializer.Serialize(Contacts);
        }

        private bool CanDeleteContactCommandExecute(object parameter)
        {
            if (Visibility)
            {
                return false;
            }
            else if (SelectedContact != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void OnApplyContactCommandExecute(object parameter)
        {
            OffProperties();
            Contacts.Add(SelectedContact);

            ContactsSerializer.Serialize(Contacts);
        }

        private bool CanApplyContactCommandExecute(object parameter)
        {
            return true;
        }

        public bool _isReadOnly { get; private set; } = true;

        public bool _isEnabled { get; private set; } = true;

        public bool _visibility { get; private set; } = false;

        public ICommand AddContactCommand { get; }

        public ICommand EditContactCommand { get; }

        public ICommand DeleteContactCommand { get; }

        public ICommand ApplyContactCommand { get; }

        public ObservableCollection<ContactVM>? Contacts { get; } = 
            ContactsSerializer.Deserialize();

        public MainVM()
        {
            AddContactCommand = new RelayCommand(OnAddContactCommandExecute,
                CanAddContactCommandExecute);
            EditContactCommand = new RelayCommand(OnEditContactCommandExecute, 
                CanEditContactCommandExecute);
            DeleteContactCommand = new RelayCommand(OnDeleteContactCommandExecure,
                CanDeleteContactCommandExecute);
            ApplyContactCommand = new RelayCommand(OnApplyContactCommandExecute, 
                CanApplyContactCommandExecute);
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
                OffProperties();
            }
        }

        public bool IsReadOnly
        {
            get { return _isReadOnly; }
            set
            {
                _isReadOnly = value;
                OnPropertyChanged();
            }
        }

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
        }

        public bool Visibility
        {
            get { return _visibility; }
            set
            {
                _visibility = value;
                OnPropertyChanged();
            }
        }

        public void OnProperties()
        {
            IsReadOnly = false;
            IsEnabled = false;
            Visibility = true;
        }

        public void OffProperties()
        {
            IsReadOnly = true;
            IsEnabled = true;
            Visibility = false;
        }
    }
}