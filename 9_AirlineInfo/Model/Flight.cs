using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_AirlineInfo
{
    class Flight
    {
        public int Number { get; private set; }
        public DateTime Arrival { get; private set; }
        public DateTime Departure { get; private set; }
        public string ArricalCity { get; private set; }
        public string DepartureCity { get; private set; }
        public string Terminal { get; private set; }
        public string Status { get; private set; }
        public int Price { get; private set; }
        public PassangersList ListOfPassengers { get; set; }

        enum FlightStatus
        {
            checkIn,
            gateClosed, 
            arrived, 
            departedAt,
            unknown, 
            canceled, 
            expectedAt, 
            delayed, 
            inFlight
        }

        public Flight(int number, DateTime arrival, DateTime departure, string arricalCity, string departureCity, string terminal, string status, int price)
        {
            Number = number;
            Arrival = arrival;
            Departure = departure;
            ArricalCity = arricalCity;
            DepartureCity = departureCity;
            Terminal = terminal;
            Status = status;
            Price = price;
        }
    }
}
