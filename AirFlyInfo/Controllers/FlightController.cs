using AirFlyInfo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirFlyInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private static readonly List<Flight> flights = VirtualDatabase.flights;

        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return flights;
        }

        [HttpGet("{flightNumber}")]
        public ActionResult<Flight> GetByFlightNumber(int flightNumber)
        {
            var flight = flights.FirstOrDefault(f => f.FlightNumber == flightNumber);

            if (flight == null)
            {
                return NotFound();
            }

            return flight;
        }
    }
}
