using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int _hours;

        private int _minutes;

        private int _seconds;

        public int Hours
        {
            get 
            { 
                return _hours; 
            }
            set
            {
                Validator.AssertValueInRange(nameof(Hours), value, 0, 23);
                _hours = value;
            }
        }

        public int Minutes
        {
            get 
            { 
                return _minutes; 
            }
            set
            {
                Validator.AssertValueInRange(nameof(Minutes), value, 0, 59);
                _minutes = value;
            }
        }

        public int Seconds
        {
            get 
            { 
                return _seconds; 
            }
            set
            {
                Validator.AssertValueInRange(nameof(Seconds), value, 0, 59);
                _seconds = value;
            }
        }

        public Time() { }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
