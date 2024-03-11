using AirFlyInfo.Models;

namespace AirFlyInfo
{
    public static class VirtualDatabase
    {
        public static readonly List<Flight> flights = new List<Flight>
        {
            new Flight { FlightNumber = 1001, Airline = "FlyBee", Departure = "JFK", Destination = "LAX", DepartureDateTime = DateTime.Now, ArrivalDateTime = DateTime.Now.AddHours(5), TrasnfersCount = 1, Price = 300 },
            new Flight { FlightNumber = 1002, Airline = "XFly", Departure = "LAX", Destination = "JFK", DepartureDateTime = new DateTime(2024,05,01,5,0,0), ArrivalDateTime = new DateTime(2024,05,01,12,0,0), TrasnfersCount = 2, Price = 350 },
            new Flight { FlightNumber = 1003, Airline = "FlyBee", Departure = "ADA", Destination = "ALB", DepartureDateTime = new DateTime(2024,05,10,15,0,0), ArrivalDateTime = new DateTime(2024,05,10,18,0,0), TrasnfersCount = 0, Price = 200 },
            new Flight { FlightNumber = 1004, Airline = "FlyBee", Departure = "ABQ", Destination = "CNF", DepartureDateTime = new DateTime(2024,05,18,18,0,0), ArrivalDateTime = new DateTime(2024,05,18,23,0,0), TrasnfersCount = 1, Price = 250 },
            new Flight { FlightNumber = 1005, Airline = "DotSky", Departure = "CFE", Destination = "VPS", DepartureDateTime = new DateTime(2024,06,01,8,0,0), ArrivalDateTime = new DateTime(2024,06,01,12,0,0), TrasnfersCount = 0, Price = 100 },
        };
    }
}
