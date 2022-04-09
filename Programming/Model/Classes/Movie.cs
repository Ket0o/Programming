using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _durationMinutes;

        private int _releaseYear;

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

        public int DurationMinutes
        {
            get 
            { 
                return _durationMinutes; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "DurationMinutes");
                _durationMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get 
            { 
                return _releaseYear; 
            }
            set
            {
                if (value < 1900)
                {
                    throw new ArgumentException("Year of manufacture since 1900");
                }
                else if(value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Last year of release, current");
                }
                else
                {
                    _releaseYear = value;
                }
            }
        }

        public string Name { get; set; }

        public string Genre { get; set; }

        public Movie() { }

        public Movie(string name, int durationMinutes, int releaseYear, string genre, double rating)
        {
            Name = name;
            DurationMinutes = durationMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }
    }
}
