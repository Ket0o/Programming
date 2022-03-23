using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        private string _estimation; // Не зачтено, удовлетворительно, хорошо, отлично
        private string Name { get; set; }
        private int NumberOfHours { get; set; }

        public Discipline()
        {

        }

        public Discipline(string estimation, string name, int numberOfHours)
        {
            Estimation = estimation;
            Name = name;
            NumberOfHours = numberOfHours;
        }

        public string Estimation
        {
            get { return _estimation; }
            set
            {
                if (value != "не зачтено"
                 || value != "удовлетворительно"
                 || value != "хорошо"
                 || value != "отлично")
                {
                    throw new ArgumentException("Оценки прописные!");
                }
                else
                    _estimation = value;
            }

        }
    }
}
