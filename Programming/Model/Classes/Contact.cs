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

        private string _name;

        private string _surname;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, "Name");
                _name = value;
            }
        }
        
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, "Surname");
                _surname = value;
            }
        }

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

        public Contact() { }

        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            for(int i = 0; i < value.Length; i++)
            {
                if(!char.IsLetter(value[i]))
                {
                    throw new ArgumentException($"{propertyName} must cintains letters only");
                }
            }
        }
    }
}
