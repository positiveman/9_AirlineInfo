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
    }
}
