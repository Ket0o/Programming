using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        /// <summary>
        /// Число после запятой может быть от 00 до 59 
        /// </summary>
        private double _duration;

        public double Duration
        {
            get 
            { 
                return _duration; 
            }
            set
            {
                if((value / 100) > 59 )
                {
                    throw new ArgumentException("In a minute 60 seconds");
                }
                else
                {
                    _duration = value;
                }
            }
        }

        public string Name { get; set; }

        public string Executor { get; set; }

        public Song() { }

        public Song(string name, string executor, double duration)
        {
            Name = name;
            Executor = executor;
            Duration = duration;
        }
    }
}
