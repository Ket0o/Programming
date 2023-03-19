using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using View.Services;

namespace View.Model
{
    public class Contact
    {
        private string _name;

        private string _email;

        private string _phone;

        public string Name
        {
            get => (_name == null) ? null : _name;
            set
            {
                Validator.NoMoreThan(value, , Name);
                _name = value;
            }
        }
    }
}
