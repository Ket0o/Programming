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

        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value < 2 || value > 5)
                {
                    throw new ArgumentException("Marks from 1 to 5");
                }
                else
                {
                    _mark = value;
                }
            }
        }

        public string Name { get; set; }

        public int HoursNumber { get; set; }

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
