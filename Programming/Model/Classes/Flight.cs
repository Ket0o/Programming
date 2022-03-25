using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightTimeInMinutes;

        public int FlightTimeInMinutes
        {
            get 
            { 
                return _flightTimeInMinutes; 
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("The flight time must be greater than 0");
                }
                else
                {
                    _flightTimeInMinutes = value;
                }
            }
        }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public Flight() { }

        public Flight(string departure, string destination, int flightTimeInMinutes)
        {
            Departure = departure;
            Destination = destination;
            FlightTimeInMinutes = flightTimeInMinutes;
        }
    }
}
