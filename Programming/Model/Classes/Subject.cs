using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Subject
    {
        /// <summary>
        /// Переделать в int (от 1 до 5)
        /// </summary>
        private int _mark;

        private int _hoursNumber;

        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Mark), value, 2, 5);
                _mark = value;
            }
        }

        public int HoursNumber
        {
            get
            {
                return _hoursNumber;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(HoursNumber));
                _hoursNumber = value;
            }
        }

        public string Name { get; set; }

        public Subject()
        {

        }

        public Subject(int mark, string name, int hoursNumber)
        {
            Mark = mark;
            Name = name;
            HoursNumber = hoursNumber;
        }
    }
}
