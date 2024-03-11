namespace AirFlyInfo.Models
{
    public class Booking
    {
        public Booking() { }
        public Booking(int id, int flightNumber, string passengerName) 
        {
            Id = id;
            FlightNumber = flightNumber;
            PassengerName = passengerName;
            BookingTime = DateTime.Now;
        }
        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public string PassengerName { get; set; }
        public DateTime BookingTime { get; set; }
    }
}
