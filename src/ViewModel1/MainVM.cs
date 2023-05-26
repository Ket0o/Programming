using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ViewModel.Services;

namespace ViewModel
{
    /// <summary>
    /// ViewModel для главного окна.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Свойство для блокировки элементов пользовательского интерфейса.
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly = true;

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private ContactVm _selectedContact;

        /// <summary>
        /// Логика команды <see cref="AddContactCommand"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        [RelayCommand(CanExecute = nameof(CanAddContact))]
        private void AddContact()
        {
            SelectedContact = null;
            ContactVm contact = new ContactVm();
            contact.Name = "";
            contact.PhoneNumber = "";
            contact.Email = "";
            SelectedContact = contact;
            IsReadOnly = false;
        }

        /// <summary>
        /// Определяет, когда команда <see cref="AddContactCommand"/> будет выполняться.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Если свойство <see cref="Visibility"/> равно true, возвращает true,
        /// иначе false.</returns>
        private bool CanAddContact()
        {
            return IsReadOnly;
        }

        /// <summary>
        /// Логика команды <see cref="EditContactCommand"/>.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        [RelayCommand(CanExecute = nameof(CanEditContact))]
        private void EditContact()
        {
            IsReadOnly = false;
        }

        /// <summary>
        /// Определяет, когда команда <see cref="EditContactCommand"/> будет выполняться.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Если свойство <see cref="Visibility"/> равно true, возвращает true,
        /// иначе false.</returns>
        private bool CanEditContact()
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
        [RelayCommand(CanExecute = nameof(CanDeleteContact))]
        private void DeleteContact()
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
        private bool CanDeleteContact()
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
        [RelayCommand(CanExecute = nameof(CanApplyContact))]
        private void ApplyContact()
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
        private bool CanApplyContact()
        {
            if (SelectedContact == null)
            {
                return false;
            }
            return !SelectedContact.HasErrors;
        }

        ///// <summary>
        ///// Команда на добавление контакта.
        ///// </summary>
        //public ICommand AddContactCommand { get; }

        ///// <summary>
        ///// Команда на редактирование контакта.
        ///// </summary>
        //public ICommand EditContactCommand { get; }

        ///// <summary>
        ///// Команда на удаление контакта.
        ///// </summary>
        //public ICommand DeleteContactCommand { get; }

        ///// <summary>
        ///// Команда на сохранение изменений данных контакта.
        ///// </summary>
        //public ICommand ApplyContactCommand { get; }

        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        public ObservableCollection<ContactVm>? Contacts { get; } =
            ContactsSerializer.Deserialize();

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            
        }

        /// <summary>
        /// Возвращает и задает выбранный контакт.
        /// </summary>
        public ContactVm SelectedContact
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
    }
}
