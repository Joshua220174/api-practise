using System;
using Hotel_Booking_API.Controllers;
using Hotel_Booking_API.Data;
using Xunit;
using FakeItEasy;

namespace HotelBookingTests
{
    public class HotelBookingTest
    {
        [Fact]
        public void GetHotels_Return_Correct_Number_Of_Bookings()
        {
            // Arrange

            var dataStore = A.Fake<ApiContext>();
            var controller = new HotelBookingController(dataStore);

            // Act 

            // Assert
        }
    }
}