using System;

namespace PI_Booking.Models
{
    public class Booking
    {
        public string? Reference { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}