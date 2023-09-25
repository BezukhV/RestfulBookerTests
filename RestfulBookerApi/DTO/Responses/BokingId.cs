using System.Text.Json.Serialization;

namespace RestfulBookerApi.DTO.Responses
{
    public class BookingId
    {
        [JsonPropertyName("bookingid")]
        public int Id { get; set; }
    }
}
