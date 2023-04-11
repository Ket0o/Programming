using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using WpfContacts.Infastructure.Commands;
using WpfContacts.Model.Services;


namespace WpfContacts.ViewModel
{
    /// <summary>
    /// ViewModel для главного окна.
    /// </summary>
    public class MainVM : Base.ViewModel
    {
        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private ContactVM _selectedContact;

        /// <summary>
        /// Логика команды <see cref="AddContactCommand"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void OnAddContactCommandExecute(object parameter)
        {
            SelectedContact = null;
            ContactVM contact = new ContactVM();
            SelectedContact = contact;
            OnProperties();
        }

        /// <summary>
        /// Определяет, когда команда <see cref="AddContactCommand"/> будет выполняться.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Если свойство <see cref="Visibility"/> равно true, возвращает true,
        /// иначе false.</returns>
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

        /// <summary>
        /// Логика команды <see cref="EditContactCommand"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void OnEditContactCommandExecute(object parameter)
        {
            ContactsSerializer.Serialize(Contacts);
            OnProperties();
        }

        /// <summary>
        /// Определяет, когда команда <see cref="EditContactCommand"/> будет выполняться.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Если свойство <see cref="Visibility"/> равно true, возвращает true,
        /// иначе false.</returns>
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

        /// <summary>
        /// Логика команды <see cref="DeleteContactCommand"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
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

        /// <summary>
        /// Определяет, когда команда <see cref="DeleteContactCommand"/> будет выполняться.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Если свойство <see cref="Visibility"/> равно true, возвращает true,
        /// иначе false.</returns>
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

        /// <summary>
        /// Логика команды <see cref="ApplyContactCommand"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void OnApplyContactCommandExecute(object parameter)
        {
            OffProperties();
            Contacts.Add(SelectedContact);

            ContactsSerializer.Serialize(Contacts);
        }

        /// <summary>
        /// Определяет, когда команда <see cref="ApplyContactCommand"/> будет выполняться.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Если свойство <see cref="Visibility"/> равно true, возвращает true,
        /// иначе false.</returns>
        private bool CanApplyContactCommandExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Свойство для блокировки пользовательского интерфейса
        /// </summary>
        public bool _isReadOnly { get; private set; } = true;

        /// <summary>
        /// 
        /// </summary>
        public bool _isEnabled { get; private set; } = true;

        /// <summary>
        /// 
        /// </summary>
        public bool _visibility { get; private set; } = false;

        /// <summary>
        /// 
        /// </summary>
        public ICommand AddContactCommand { get; }

        /// <summary>
        /// 
        /// </summary>
        public ICommand EditContactCommand { get; }

        /// <summary>
        /// 
        /// </summary>
        public ICommand DeleteContactCommand { get; }

        /// <summary>
        /// 
        /// </summary>
        public ICommand ApplyContactCommand { get; }

        /// <summary>
        /// 
        /// </summary>
        public ObservableCollection<ContactVM>? Contacts { get; } =
            ContactsSerializer.Deserialize();

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        public bool IsReadOnly
        {
            get { return _isReadOnly; }
            set
            {
                _isReadOnly = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Visibility
        {
            get { return _visibility; }
            set
            {
                _visibility = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void OnProperties()
        {
            IsReadOnly = false;
            IsEnabled = false;
            Visibility = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void OffProperties()
        {
            IsReadOnly = true;
            IsEnabled = true;
            Visibility = false;
        }
    }
}