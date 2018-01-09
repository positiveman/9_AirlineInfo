using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_AirlineInfo
{
    class FlightList :  IMaintanable<Flight>
    {
        List<Flight> TimeTable = new List<Flight> { };

        

        public void Create(Flight obj)
        {
            TimeTable.Add(obj);

        }

        public void Delete(int key)
        {
            TimeTable.RemoveAt(key);
        }

        public Flight Get(int key)
        {
            Flight flight = TimeTable[key];
            return flight;
        }

        public void Update(Flight obj)
        {
            Flight updateFlight = null;
            foreach (Flight flight in TimeTable)
            {
                if (flight.Number == obj.Number)
                {
                    updateFlight = flight;
                }
            }

            if (updateFlight != null)
            {
                TimeTable.Remove(updateFlight);
                TimeTable.Add(obj);

            }
            else
            {
                Console.WriteLine("Flight with number {0} doesn't exist", obj.Number);
            }
        }

        public void AddPassenger(int flightNumber, Passenger pass)
        {
            int count = 0;
            foreach (var item in TimeTable)
            {
                if (item.Number == flightNumber)
                {
                    count++;
                    item.ListOfPassengers.Add(pass);
                }
            }

            if (count==0)
            {
                Console.WriteLine("Flight with number {0} was not found", flightNumber);
            }

        }


        public void GetTimetable()
        {
            foreach (var item in TimeTable)
            {
                Console.WriteLine("Flight number:"+ item.Number + " Arrival time: "+item.Arrival + " Departure time: "+item.Departure + " from: "+ item.ArrivalCity +" to: "+ item.DepartureCity + " Terminal: "+item.Terminal +" Status: "+ item.Status);
            }


        }

        public void GetPricelist()
        {
            foreach (var item in TimeTable)
            {
                Console.WriteLine("Flight number: " + item.Number + " " + item.ArrivalCity + " - " + item.DepartureCity + " Price: " +item.Price+ "$");

            }

        }

        public void GetPassengersList()
        {
            foreach (var item in TimeTable)
            {
                Console.WriteLine("Flight number: " + item.Number + " " + item.ArrivalCity + " - " + item.DepartureCity + "\n Passengers:");
                foreach (var passenger in item.ListOfPassengers)
                {
                    Console.WriteLine(passenger.FirstName +" "+ passenger.LastName +"; sex: " +passenger.Sex + "; nationality: "+ passenger.Nationality + "; passport: "+ passenger.Passport);
                }

            }


        }


        public void SearchByFlightNumber(int number)
        {
            foreach (var item in TimeTable)
            {
                if (item.Number == number)
                {
                    Console.WriteLine(item.ToString());

                }


            }


        }

        public void SearchByArrivalCity(string city)
        {
            foreach (var item in TimeTable)
            {
                if (item.ArrivalCity == city)
                {
                    Console.WriteLine(item.ToString());

                }


            }


        }

        public void SearchByDepartureCity(string city)
        {
            foreach (var item in TimeTable)
            {
                if (item.DepartureCity == city)
                {
                    Console.WriteLine(item.ToString());

                }


            }


        }

        public void SearchByCost(int cost)
        {
            foreach (var item in TimeTable)
            {
                if (item.Price > cost -10 && item.Price < cost +10)
                {
                    Console.WriteLine(item.ToString());

                }


            }


        }




    }
}
