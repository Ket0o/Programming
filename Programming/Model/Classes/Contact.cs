using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о телефонном контакте
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Регулярное выражение(только цифры)
        /// </summary>
        private readonly Regex regex = new Regex (@"\d{11}");
        /// <summary>
        /// Уникальный номер телефона для всех объектов класса
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Уникальное имя для всех объектов класса
        /// </summary>
        private string _name;
        /// <summary>
        /// Уникальная фамилия для всех объектов класса
        /// </summary>
        private string _surname;
        /// <summary>
        /// Возвращает и создает имя человека. Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = AssertStringContainsOnlyLetters (nameof(Name), value);
            }
        }
        /// <summary>
        /// Возвращает и задает фамилию человека. Должна состоять только из букв.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = AssertStringContainsOnlyLetters (nameof(Surname), value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                MatchCollection matches = regex.Matches (value);
                if (matches.Count != 11)
                {
                    throw new ArgumentException ("Enter only numbers");
                }
                if (value.Length > 11)
                {
                    throw new ArgumentException ("The phone number contains more than 11 digits");
                }
                else
                {
                    _phoneNumber = value;
                }
            }
        }

        public Contact () 
        { 

        }

        public Contact (string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        private string AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException ($"{propertyName} must cintains letters only");
                }
            }

            return value; 
        }
    }
}
