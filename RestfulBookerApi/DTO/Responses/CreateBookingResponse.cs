using RestfulBookerApi.DTO.Requests;
using System.Text.Json.Serialization;

namespace RestfulBookerApi.DTO.Responses
{
    public class CreateBookingResponse
    {
        [JsonPropertyName("bookingid")]
        public int BookingId { get; set; }
        [JsonPropertyName("booking")]
        public BookingInfo Booking { get; set; }
    }
}
