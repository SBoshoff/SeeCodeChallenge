using System;

namespace BusinessLogic.Models
{
    public class Event
    {
        public string? EventName { get; set; }
        public string? Venue { get; set; }
        public DateTime? Date { get; set; }
        public string? ImageUrl { get; set; }
        public string? Status { get; set; }
    }
}
