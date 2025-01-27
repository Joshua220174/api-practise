using Microsoft.EntityFrameworkCore;
using Hotel_Booking_API.Models;

namespace Hotel_Booking_API.Data
{
    public class ApiContext : DbContext
    {

        public DbSet<HotelBooking> Bookings { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {

        }
    }
}
