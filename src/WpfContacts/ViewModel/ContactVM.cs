using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using WpfContacts.Model;

namespace WpfContacts.ViewModel
{
    /// <summary>
    /// ViewModel для contact.
    /// </summary>
    public class ContactVm : Base.ViewModel, INotifyDataErrorInfo
    {
        /// <summary>
        /// Экземпляр класса <see cref="ErrorsVM"/>.
        /// </summary>
        private readonly ErrorsVM _errorsVm;

        /// <summary>
        /// Зажигает событие <see cref="ErrorsChanged"/>
        /// </summary>
        /// <param name="sender">Объект, который вызвал событие.</param>
        /// <param name="e">Параметр.</param>
        private void ErrorsVM_ErrorsChanged(object? sender, DataErrorsChangedEventArgs e)
        {
            ErrorsChanged?.Invoke(this, e);
            OnPropertyChanged();
        }

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
                _errorsVm.ClearErrors(nameof(Name));
                if ((Contact.Name.Length == 0) || (Contact.Name.Length > 100))
                {
                    _errorsVm.AddError(nameof(Name), 
                        "Name должен быть не длиннее 100 символов");
                }
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
                _errorsVm.ClearErrors(nameof(PhoneNumber));
                if ((Contact.PhoneNumber.Length > 100) || (Contact.PhoneNumber.Length == 0))
                {
                    _errorsVm.AddError(nameof(PhoneNumber),
                        "PhoneNumber должен быть не длиннее 100 символов и может " +
                        "содержать только цифры или символы +-() ." +
                        "\r\nПример: +7 (999) 111-22-33\r\n");
                }
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
                _errorsVm.ClearErrors(nameof(Email));
                if (((Contact.Email.Length > 100) || (Contact.Email.Length == 0)) || 
                    (new Regex("[@]").IsMatch(Contact.Email) == false))
                {
                    _errorsVm.AddError(nameof(Email),
                        "Email должен быть не длиннее 100 символов и должен содержать" +
                        "\r\nсимвол @ .");
                }
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает true или false, в зависимости от того, есть ли ошибки.
        /// </summary>
        public bool HasErrors => _errorsVm.HasErrors;

        /// <summary>
        /// Событие измнение ошибки.
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVm"/>
        /// </summary>
        public ContactVm()
        {
            _errorsVm = new ErrorsVM();
            _errorsVm.ErrorsChanged += ErrorsVM_ErrorsChanged;
        }

        /// <summary>
        /// Извлекает имя объекта.
        /// </summary>
        /// <param name="propertyName">Имя объекта.</param>
        /// <returns><see cref="propertyName"/> или <see cref="null"/>.</returns>
        public IEnumerable GetErrors(string? propertyName)
        {
            return _errorsVm.GetErrors(propertyName);
        }
    }
}
