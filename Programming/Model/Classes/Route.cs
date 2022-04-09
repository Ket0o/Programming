using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Route
    {
        private int _flightTimeMinutes;

        public int FlightTimeMinutes
        {
            get 
            { 
                return _flightTimeMinutes; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "FlightTimeMinutes");
                _flightTimeMinutes = value;
            }
        }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public Route() { }

        public Route(string departure, string destination, int flightTimeMinutes)
        {
            Departure = departure;
            Destination = destination;
            FlightTimeMinutes = flightTimeMinutes;
        }
    }
}
