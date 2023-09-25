using Refit;
using RestfulBookerApi.DTO.QueryParams;
using RestfulBookerApi.DTO.Requests;
using RestfulBookerApi.DTO.Responses;

namespace RestfulBookerApi
{
    public interface IRestfulBookerApi
    {
        private const string path = "/booking";

        [Post("/auth")]
        [Headers("Content-Type: application/json")]
        Task<TokenResponse> CreateToken([Body] User payload);

        [Post(path)]
        [Headers("Accept: application/json", "Content-Type: application/json")]
        Task<ApiResponse<CreateBookingResponse>> CreateBooking([Body] BookingInfo payload);

        [Get(path + "/{bookingId}")]
        [Headers("Accept: application/json")]
        Task<ApiResponse<BookingInfo>> GetBooking(int bookingId);

        [Get(path)]
        Task<ApiResponse<BookingId[]>> GetBookingIds(GetBookingIdsParams parameters);

        [Patch("/booking/{bookingId}")]
        [Headers("Content-Type: application/json", "Accept: application/json")]
        Task<ApiResponse<BookingInfo>> PatchBooking(int bookingId, [Body] string payload, [Header("Cookie")] string token);

        [Delete("/booking/{bookingId}")]
        [Headers("Content-Type: application/json")]
        Task<ApiResponse<BookingInfo>> DeleteBooking(int bookingId, [Header("Cookie")] string token);
    }
}