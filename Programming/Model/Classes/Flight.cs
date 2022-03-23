using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private string PointOfDeparture { get; set; }
        private string Destination { get; set; }
        private int _flightTimeInMinutes;

        public Flight() { }

        public Flight(string pointOfDeparture, string destination, int flightTimeInMinutes)
        {
            PointOfDeparture = pointOfDeparture;
            Destination = destination;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        public int FlightTimeInMinutes
        {
            get { return _flightTimeInMinutes; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Время полета должно быть больше 0");
                }
                else
                {
                    _flightTimeInMinutes = value;
                }
            }
        }
    }
}
