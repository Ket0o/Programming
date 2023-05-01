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
            IsReadOnly = false;
        }

        /// <summary>
        /// Определяет, когда команда <see cref="AddContactCommand"/> будет выполняться.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Если свойство <see cref="Visibility"/> равно true, возвращает true,
        /// иначе false.</returns>
        private bool CanAddContactCommandExecute(object parameter)
        {
            return IsReadOnly;
        }

        /// <summary>
        /// Логика команды <see cref="EditContactCommand"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void OnEditContactCommandExecute(object parameter)
        {
            IsReadOnly = false;
        }

        /// <summary>
        /// Определяет, когда команда <see cref="EditContactCommand"/> будет выполняться.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Если свойство <see cref="Visibility"/> равно true, возвращает true,
        /// иначе false.</returns>
        private bool CanEditContactCommandExecute(object parameter)
        {
            if (SelectedContact != null)
            {
                return IsReadOnly;
            }

            return !IsReadOnly;
        }

        /// <summary>
        /// Логика команды <see cref="DeleteContactCommand"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void OnDeleteContactCommandExecute(object parameter)
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
            if (SelectedContact != null)
            {
                return IsReadOnly;
            }

            return !IsReadOnly;
        }

        /// <summary>
        /// Логика команды <see cref="ApplyContactCommand"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        private void OnApplyContactCommandExecute(object parameter)
        {
            IsReadOnly = true;
            if (Contacts.Contains(SelectedContact))
            {
                ContactsSerializer.Serialize(Contacts);
            }
            else
            {
                Contacts.Add(SelectedContact);
                ContactsSerializer.Serialize(Contacts);
            }
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
        /// Свойство для блокировки элементов пользовательского интерфейса.
        /// </summary>
        private bool _isReadOnly = true; 


        /// <summary>
        /// Команда на добавление контакта.
        /// </summary>
        public ICommand AddContactCommand { get; }

        /// <summary>
        /// Команда на редактирование контакта.
        /// </summary>
        public ICommand EditContactCommand { get; }

        /// <summary>
        /// Команда на удаление контакта.
        /// </summary>
        public ICommand DeleteContactCommand { get; }

        /// <summary>
        /// Команда на сохранение изменений данных контакта.
        /// </summary>
        public ICommand ApplyContactCommand { get; }

        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        public ObservableCollection<ContactVM>? Contacts { get; } =
            ContactsSerializer.Deserialize();

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            AddContactCommand = new RelayCommand(OnAddContactCommandExecute,
                CanAddContactCommandExecute);
            EditContactCommand = new RelayCommand(OnEditContactCommandExecute,
                CanEditContactCommandExecute);
            DeleteContactCommand = new RelayCommand(OnDeleteContactCommandExecute,
                CanDeleteContactCommandExecute);
            ApplyContactCommand = new RelayCommand(OnApplyContactCommandExecute,
                CanApplyContactCommandExecute);
        }

        /// <summary>
        /// Возвращает и задает выбранный контакт.
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
                IsReadOnly = true;
            }
        }

        /// <summary>
        /// Возвращает и задает свойство для блокировки элементов пользовательского интерфейса.
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
    }
}
