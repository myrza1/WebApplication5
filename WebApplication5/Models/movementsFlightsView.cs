//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class movementsFlightsView
    {
        public string registration { get; set; }
        public string iataCode { get; set; }
        public string arr_flightNumer { get; set; }
        public Nullable<System.DateTime> arr_scheduleTime { get; set; }
        public string airlineIATA { get; set; }
        public Nullable<int> MTOW { get; set; }
        public string airportIATA { get; set; }
        public string airportICAO { get; set; }
        public string airportName { get; set; }
        public string dep_flightNumber { get; set; }
        public Nullable<System.DateTime> dep_schedTime { get; set; }
        public string flight_to { get; set; }
        public string flight_from { get; set; }
        public Nullable<long> arrivalFlightId { get; set; }
        public Nullable<long> departureFlightId { get; set; }
        public long movementId { get; set; }
    }
}