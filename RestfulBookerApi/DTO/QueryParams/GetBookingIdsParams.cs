using Refit;

namespace RestfulBookerApi.DTO.QueryParams
{
    public class GetBookingIdsParams
    {
        [AliasAs("firstname")]
        public string FirstName { get; set; }
        [AliasAs("lastname")]
        public string LastName { get; set; }
        [AliasAs("checkin")]
        public string CheckIn { get; set; }
        [AliasAs("checkout")]
        public string CheckOut { get; set; }
    }
}
