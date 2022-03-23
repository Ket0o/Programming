using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Film
    {
        private string Title { get; set; }
        private int _durationInMinutes;
        private int _yearOfRelease;
        private string Genre { get; set; }
        private double _rating;

        public Film() { }

        public Film(string title, int durationInMinutes, int yearOfRelease, string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            Rating = rating;
        }

        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value < 0
                 || value > 10 )
                {
                    throw new ArgumentException("Рейтинг выставляется по 10 бальной шкале");
                }
                else
                {
                    _rating = value;
                }
            }
        }

        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set
            {
                if (value <=0)
                {
                    throw new ArgumentException("Продолжительность фильма должна быть больше 0");
                }
                else
                {
                    _durationInMinutes = value;
                }
            }
        }

        public int YearOfRelease
        {
            get { return _yearOfRelease; }
            set
            {
                if (value < 1900)
                {
                    throw new ArgumentException("Год выпуска с 1900 года");
                }
                else if(value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Крайний год издания, нынешний");
                }
                else
                {
                    _yearOfRelease = value;
                }
            }
        }

    }
}
