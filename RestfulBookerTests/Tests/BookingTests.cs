using FluentAssertions;
using RestfulBookerApi.DTO.QueryParams;
using RestfulBookerTests.Controllers;
using System.Net;

namespace RestfulBookerTests.Tests
{
    public class BookingTests
    {
        [Test]
        public void GetBooking()
        {
            var bookingId = BookingController.CreateDefaultBookingAndReturnId();
            var response = BookingController.GetBookingByIdAsync(bookingId).Result;
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.Should().BeEquivalentTo(BookingController.GetDefaultBookingPayload());
        }

        [Test]
        public void GetBookingIdsByFullName()
        {
            int[] expextedBookingIds = new int[10];
            for (int i = 0; i < 10; i++)
            {
                expextedBookingIds[i] = (int)BookingController.CreateDefaultBookingAndReturnId();
            }
            var query = new GetBookingIdsParams
            {
                FirstName = BookingController.GetDefaultBookingPayload().FirstName,
                LastName = BookingController.GetDefaultBookingPayload().LastName
            };

            var response = BookingController.GetBookingIdsAsync(query).Result.Content?.Select(x => x.Id).ToArray();
            response.Should().Contain(expextedBookingIds);
        }

        [Test]
        public void CreateBooking()
        {
            var response = BookingController.CreateDefaultBookingAsync().Result;
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.Booking.Should().BeEquivalentTo(BookingController.GetDefaultBookingPayload());
        }

        [Test]
        public void UpdateBooking()
        {
            var bookingId = BookingController.CreateDefaultBookingAndReturnId();

            var bookingInfo = "{\"firstname\":\"Updated2\"}";
            var response = BookingController.PartialUpdateBookingAsync(bookingId, bookingInfo).Result;

            var expectedBookingInfo = BookingController.GetDefaultBookingPayload();
            expectedBookingInfo.FirstName = "Updated2";
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            response.Content.Should().BeEquivalentTo(expectedBookingInfo);
        }

        [Test]
        public void DeleteBooking()
        {
            var bookingId = BookingController.CreateDefaultBookingAndReturnId();
            var response = BookingController.DeleteBookingAsync(bookingId).Result;
            response.StatusCode.Should().Be(HttpStatusCode.Created);
            response.Content.Should().Be(null);
        }
    }
}