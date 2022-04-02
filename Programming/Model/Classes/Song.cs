using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private int _durationSeconds;

        public int Duration
        {
            get 
            { 
                return _durationSeconds; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("the value of the Duration Seconds field must be greater than zero");
                }
                _durationSeconds = value;
            }
        }

        public string Name { get; set; }

        public string Author { get; set; }

        public Song() { }

        public Song(string name, string author, int durationSeconds)
        {
            Name = name;
            Author = author;
            Duration = durationSeconds;
        }
    }
}
