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
        public string ArrivalCity { get; private set; }
        public string DepartureCity { get; private set; }
        public string Terminal { get; private set; }
        public string Status { get; private set; }
        public int Price { get; private set; }
        public List<Passenger> ListOfPassengers { get; set; }

        public override string ToString()
        {
            return "Flight number:" + Number + " Arrival time: " + Arrival + " Departure time: " + Departure + " from: " + ArrivalCity + " to: " + DepartureCity + " Terminal: " + Terminal + " Status: " + Status +" Price: " + Price;
        }

        public Flight(int number, DateTime arrival, DateTime departure, string arricalCity, string departureCity, string terminal, string status, int price)
        {
            Number = number;
            Arrival = arrival;
            Departure = departure;
            ArrivalCity = arricalCity;
            DepartureCity = departureCity;
            Terminal = terminal;
            Status = status;
            Price = price;
            ListOfPassengers = new List<Passenger> { };
        }
    }
}
