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
                Validator.AssertValueInRange (nameof(Rating), value, 0d, 10d);
                _rating = value;
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
                Validator.AssertOnPositiveValue (value, nameof(DurationMinutes));
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
                Validator.AssertValueInRange (nameof(ReleaseYear), value, 1900, 2022);
                _releaseYear = value;
            }
        }

        public string Name { get; set; }

        public string Genre { get; set; }

        public Movie () 
        {

        }

        public Movie (string name, int durationMinutes, int releaseYear, string genre, double rating)
        {
            Name = name;
            DurationMinutes = durationMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }
    }
}
