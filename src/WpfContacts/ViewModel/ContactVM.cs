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
    public class ContactVM : Base.ViewModel, INotifyDataErrorInfo
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ErrorsVM errorsVM;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                errorsVM.ClearErrors(nameof(Name));
                if ((Contact.Name.Length == 0) || (Contact.Name.Length > 100))
                {
                    errorsVM.AddError(nameof(Name), 
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
                errorsVM.ClearErrors(nameof(PhoneNumber));
                if ((Contact.PhoneNumber.Length > 100) || (Contact.PhoneNumber.Length == 0))
                {
                    errorsVM.AddError(nameof(PhoneNumber),
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
                errorsVM.ClearErrors(nameof(Email));
                if (((Contact.Email.Length > 100) || (Contact.Email.Length == 0)) || 
                    (new Regex("[@]").IsMatch(Contact.Email) == false))
                {
                    errorsVM.AddError(nameof(Email),
                        "Email должен быть не длиннее 100 символов и должен содержать" +
                        "\r\nсимвол @ .");
                }
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool HasErrors => errorsVM.HasErrors;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        /// <summary>
        /// 
        /// </summary>
        public ContactVM()
        {
            errorsVM = new ErrorsVM();
            errorsVM.ErrorsChanged += ErrorsVM_ErrorsChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public IEnumerable GetErrors(string? propertyName)
        {
            return errorsVM.GetErrors(propertyName);
        }
    }
}
