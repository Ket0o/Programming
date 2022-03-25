using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        /// <summary>
        /// Переделать в int (от 1 до 5)
        /// </summary>
        private int _estimation;

        public int Estimation
        {
            get
            {
                return _estimation;
            }
            set
            {
                if (value != 1
                 || value != 2
                 || value != 3
                 || value != 4
                 || value != 5)
                {
                    throw new ArgumentException("Grades from 1 to 5");
                }
                else
                {
                    _estimation = value;
                }
            }

        }

        public string Name { get; set; }

        public int NumberOfHours { get; set; }

        public Discipline()
        {

        }

        public Discipline(int estimation, string name, int numberOfHours)
        {
            Estimation = estimation;
            Name = name;
            NumberOfHours = numberOfHours;
        }
    }
}
