using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_AirlineInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FlightList ListOfFlights = new FlightList();

            ListOfFlights.Create(new Flight(1,new DateTime(2018, 6, 1, 12, 0, 0), new DateTime(2018, 6, 1, 14, 0, 0), "Kharkiv","Berlin","A1","ckeck-in",100));
            ListOfFlights.Create(new Flight(2, new DateTime(2018, 8, 1, 8, 0, 0), new DateTime(2018, 8, 1, 15, 0, 0), "Kharkiv", "Bergamo", "A2", "arrived", 150));
            ListOfFlights.Create(new Flight(6, new DateTime(2018, 7, 2, 12, 0, 0), new DateTime(2018, 6, 1, 14, 45, 0), "London", "Kharkiv", "A1", "ckeck-in", 250));
            ListOfFlights.Create(new Flight(9, new DateTime(2018, 8, 3, 8, 0, 0), new DateTime(2018, 8, 3, 9, 30, 0), "Kyiv", "Kharkiv", "A2", "arrived", 50));


            ListOfFlights.AddPassenger(1, new Passenger("Oleg", "Avdyeyev", "UKR", "AA000000", new DateTime(1991, 12, 16), "business", "M"));

            while (true)
            {
                

                Console.WriteLine("Please check: \n 1. Show timetable \n 2. Show pricelist \n 3. Show passangers list \n 4. Search flight \n 5. Add passanger to flight");

                int Answer;
                Answer = int.Parse( Console.ReadLine());

                switch (Answer)
                {

                    case 1:
                        ListOfFlights.GetTimetable();
                        break;

                    case 2:
                        ListOfFlights.GetPricelist();
                        break;

                    case 3:
                        ListOfFlights.GetPassengersList();
                        break;

                    case 4:

                        Console.WriteLine("Please check search parameter: \n 1. Flight number \n 2. Arrival city \n 3. Departure city \n 4. Price ");

                        int SearchParameter;
                        SearchParameter = int.Parse(Console.ReadLine());

                        switch (SearchParameter)
                        {
                            case 1:
                                Console.WriteLine("Please type flight number you want to search:");
                                int FlightNumber;
                                FlightNumber = int.Parse(Console.ReadLine());
                                ListOfFlights.SearchByFlightNumber(FlightNumber);

                                break;

                            case 2:
                                Console.WriteLine("Please type arrival city you want to search:");
                                string ArrivalCity = Console.ReadLine();
                                ListOfFlights.SearchByArrivalCity(ArrivalCity);
                                break;
                            
                            case 3:
                                Console.WriteLine("Please type departure city you want to search:");
                                string DepartureCity = Console.ReadLine();
                                ListOfFlights.SearchByArrivalCity(DepartureCity);
                                break;
                            case 4:
                                Console.WriteLine("Please type flight cost +/- 10$ you want to search:");
                                int FlightCost;
                                FlightCost = int.Parse(Console.ReadLine());
                                ListOfFlights.SearchByCost(FlightCost);
                                break;
                        }

                        break;

                    case 5:
                        Console.WriteLine("Please enter the number of flight:");
                        int number;
                        number = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please passenger's first name:");
                        string firstName = Console.ReadLine();

                        Console.WriteLine("Please passenger's second name:");
                        string secondName = Console.ReadLine();

                        Console.WriteLine("Please passenger's sex:");
                        string sex = Console.ReadLine();

                        Console.WriteLine("Please passenger's nationality:");
                        string nationality = Console.ReadLine();

                        Console.WriteLine("Please passenger's passport:");
                        string passport = Console.ReadLine();

                        Console.WriteLine("Please passenger's flight class:");
                        string flightClass = Console.ReadLine();

                        Console.WriteLine("Please passenger's year of birth:");
                        int year;
                        year = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please passenger's month of birth:");
                        int month;
                        month = int.Parse(Console.ReadLine());

                        Console.WriteLine("Please passenger's day of birth:");
                        int day;
                        day = int.Parse(Console.ReadLine());


                        Passenger pass = new Passenger(firstName, secondName,nationality, passport, new DateTime(year, month, day), flightClass, sex );
                        ListOfFlights.AddPassenger(number, pass);

                        break;

                        case 6:
                        break;

                        
                        
                        
                }
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
