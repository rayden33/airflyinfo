using AirFlyInfo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirFlyInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private static readonly List<Flight> flights = VirtualDatabase.flights;
        private static List<Booking> bookings = new List<Booking>();
        private static int bookingIdCounter = 1;


        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            return bookings;
        }

        [HttpPost]
        public ActionResult<Booking> BookFlight([FromBody] Booking bookingRequest)
        {
            var flight = flights.FirstOrDefault(f => f.FlightNumber == bookingRequest.FlightNumber);
            if (flight == null)
            {
                return NotFound("Flight not found.");
            }

            var booking = new Booking(bookingIdCounter++, bookingRequest.FlightNumber, bookingRequest.PassengerName);

            bookings.Add(booking);

            return Ok(booking);
        }
    }
}
