using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private readonly Regex regex = new Regex(@"\d{11}");

        /// <summary>
        /// Телефонный номер. Не более 11 знаков
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Проверка на ввод цифр
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                MatchCollection matches = regex.Matches(value);
                if(matches.Count != 11)
                {
                    throw new ArgumentException("Enter only numbers");
                }
                if (value.Length > 11)
                {
                    throw new ArgumentException("The phone number contains more than 11 digits");
                }
                else
                {
                    _phoneNumber = value;
                }
            }
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Contact() { }

        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

    }
}
