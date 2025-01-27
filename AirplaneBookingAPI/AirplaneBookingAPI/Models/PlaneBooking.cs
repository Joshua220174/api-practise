namespace AirplaneBookingAPI.Models
{
    public class PlaneBooking
    {
        public int Id { get ; set; }
        public int FlightNumber { get; set; }
        public string? AllocatedSeat {  get; set; }
        public string? AirlineName { get; set; }
        public string? ClientName { get; set; } 

    }
}
