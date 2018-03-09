using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public class movementVFlights
    {
        public string registration { get; set; }
        public string iataCode { get; set; }
        public string arr_flightNumer { get; set; }
        public DateTime arr_scheduleTime { get; set; }
        public string airlineIATA { get; set; }
        public int MTOW { get; set; }
        public string airportIATA { get; set; }
        public string airportICAO { get; set; }
        public string airportName { get; set; }
        public string dep_flightNumber { get; set; }
        public DateTime dep_schedTime { get; set; }
        public string flight_to { get; set; }
        public string flight_from { get; set; }
        public long arrivalFlightId { get; set; }
        public long departureFlightId { get; set; }
        public long movementId { get; set; }
    }
}