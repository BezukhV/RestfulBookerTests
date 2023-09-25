using System.Text.Json.Serialization;

namespace RestfulBookerApi.DTO.Requests
{
    public class BookingDates
    {
        [JsonPropertyName("checkin")]
        public string CheckIn { get; set; }

        [JsonPropertyName("checkout")]
        public string CheckOut { get; set; }
    }

   
    public class BookingInfo
    {

        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastname")]
        public string LastName { get; set; }

        [JsonPropertyName("totalprice")]
        public int TotalPrice { get; set; }

        [JsonPropertyName("depositpaid")]
        public bool DepositPaid { get; set; }

        [JsonPropertyName("bookingdates")]
        public BookingDates BookingDates { get; set; }

        [JsonPropertyName("additionalneeds")]
        public string AdditionalNeeds { get; set; }
    }
}
