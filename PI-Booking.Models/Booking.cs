using System;

namespace PI_Booking.Models
{
    public class Booking
    {
        public string? Reference { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}