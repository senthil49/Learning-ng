using System;
using System.Collections.Generic;
using System.Web.Http;

using Airlines.Model;

namespace Airlines.Controllers
{
    public class FlightsController : ApiController
    {
        public IHttpActionResult GetAllFlights()
        {
            var model = new List<Flight>
            {
                new Flight() { Id = 1, Airline = "United", Approved = false, Cities = new [] {"ORD", "NWK"}, StartTime = DateTime.Now, EndTime = DateTime.Now, Date = DateTime.Today, Price = 500, TotalDuration = 3, FlightNumber = "UA1546" },
                new Flight() { Id = 2, Airline = "AA", Approved = false, Cities = new [] {"SFO", "MNS"}, StartTime = DateTime.Now, EndTime = DateTime.Now, Date = DateTime.Today, Price = 1500, TotalDuration = 6, FlightNumber = "UA1546" }
            };

            return Ok(model);
        }

    }
}