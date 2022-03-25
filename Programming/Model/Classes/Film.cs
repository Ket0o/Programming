using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Film
    {
        private int _durationInMinutes;

        private int _yearOfRelease;

        private double _rating;

        public double Rating
        {
            get 
            { 
                return _rating; 
            }
            set
            {
                if (value < 0 || value > 10 )
                {
                    throw new ArgumentException("The rating is set on a 10-point scale");
                }
                else
                {
                    _rating = value;
                }
            }
        }

        public int DurationInMinutes
        {
            get 
            { 
                return _durationInMinutes; 
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The duration of the movie must be greater than 0");
                }
                else
                {
                    _durationInMinutes = value;
                }
            }
        }

        public int YearOfRelease
        {
            get 
            { 
                return _yearOfRelease; 
            }
            set
            {
                if (value < 1900)
                {
                    throw new ArgumentException("Year of manufacture since 1900");
                }
                else if(value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Last year of publication, current");
                }
                else
                {
                    _yearOfRelease = value;
                }
            }
        }

        public string Name { get; set; }

        public string Genre { get; set; }

        public Film() { }

        public Film(string name, int durationInMinutes, int yearOfRelease, string genre, double rating)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
            YearOfRelease = yearOfRelease;
            Genre = genre;
            Rating = rating;
        }
    }
}
