using Microsoft.EntityFrameworkCore;
using AirplaneBookingAPI.Models;

namespace AirplaneBookingAPI.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<PlaneBooking> Bookings { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {

        }
    }
}
