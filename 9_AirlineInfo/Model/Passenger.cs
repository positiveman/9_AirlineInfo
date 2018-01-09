using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_AirlineInfo
{
    class Passenger
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Nationality { get; private set; }
        public string Passport { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string FlightClass { get; private set; }
        public string Sex { get; private set; }

        public Passenger(string firstName, string lastName, string nationality, string passport, DateTime dateOfBirth, string flightClass, string sex)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
            Passport = passport;
            DateOfBirth = dateOfBirth;
            FlightClass = flightClass;
            Sex = sex;
        }
    }
}
