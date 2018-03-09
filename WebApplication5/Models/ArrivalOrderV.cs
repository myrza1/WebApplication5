using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class ArrivalOrderV
    {
        public string name { get; set; }
        public string status { get; set; }
        public Nullable<bool> isFinished { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public string flightNumber { get; set; }
        public System.DateTime scheduledTime { get; set; }
        public Nullable<double> manni { get; set; }
        public Nullable<System.DateTime> start_time { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public Nullable<long> arrival_id { get; set; }
        public long arrivalFlightId { get; set; }
        public int id { get; set; }
    }
}