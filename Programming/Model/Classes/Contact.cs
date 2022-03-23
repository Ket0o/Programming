using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private string _phoneNumber; // (11 знаков максимум)

        public Contact() { }

        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if(value.Length > 11)
                {
                    throw new ArgumentException("Телефонный номер содержит больше 11 цифр");
                }
                else
                {
                    _phoneNumber = value;
                }
            }
        }
    }
}
