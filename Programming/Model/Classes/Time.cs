using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int _clock;
        private int _minutes;
        private int _seconds;

        public Time() { }

        public Time(int clock, int minutes, int seconds)
        {
            Clock = clock;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int Clock
        {
            get { return _clock; }
            set
            {
                if (value < 0
                 || value > 23)
                {
                    throw new ArgumentException("Часов может быть от 0 до 23");
                }
                else
                {
                    _clock = value;
                }
            }
        }

        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if(value < 0
                || value > 60)
                {
                    throw new ArgumentException("Минуты могут быть от 0 до 60");
                }
                else
                {
                    _minutes = value;
                }
            }
        }

        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value < 0
                 || value > 60)
                {
                    throw new ArgumentException("Секунды могут быть от 0 до 60");
                }
                else
                {
                    _seconds = value;
                }
            }
        }
    }
}
