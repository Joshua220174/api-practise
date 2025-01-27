using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AirplaneBookingAPI.Models;
using AirplaneBookingAPI.Data;
using System.Security.Cryptography.Xml;

namespace AirplaneBookingAPI.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class PlaneBookingsController : ControllerBase
    {
        private readonly ApiContext _context;

        public PlaneBookingsController(ApiContext context)
        {
            _context = context;
        }


        // Create / edit
        [HttpPost]
        public JsonResult CreateEdit(PlaneBooking booking)
        {
            if (booking.Id == 0)
            {
                _context.Bookings.Add(booking);
            }
            else
            {
                var bookingInDb = _context.Bookings.Find(booking.Id);

                if (bookingInDb == null)
                    return new JsonResult(NotFound());

                bookingInDb = booking;

            }
            _context.SaveChanges();

            return new JsonResult(Ok(booking));
        }

        [HttpGet]
        public JsonResult Get(int iD)
        {
            var result = _context.Bookings.Find(iD);

            if(result == null)
            {
                return new JsonResult(NotFound());
            }
            else
            {
                return new JsonResult(Ok(result));
            }
        }

        [HttpDelete]
        public JsonResult Delete(int iD)
        {
            var result = _context.Bookings.Find(iD);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Bookings.Remove(result);

            _context.SaveChanges();

            return new JsonResult(Ok(result));
        }

        [HttpGet()]
        public JsonResult GetAll()
        {
            var result = _context.Bookings.ToList();

            return new JsonResult(Ok(result));
        }
    }
}
