using Refit;
using RestfulBookerApi;
using RestfulBookerApi.DTO.QueryParams;
using RestfulBookerApi.DTO.Requests;
using RestfulBookerApi.DTO.Responses;

namespace RestfulBookerTests.Controllers
{
    internal class BookingController : BaseController
    {
        internal static async Task<ApiResponse<BookingInfo>> GetBookingByIdAsync(int bookingId)
        {
            return await apiClient.GetBooking(bookingId);
        }
        internal static async Task<ApiResponse<CreateBookingResponse>> CreateDefaultBookingAsync()
        {
            return await apiClient.CreateBooking(GetDefaultBookingPayload());
        }

        internal static int CreateDefaultBookingAndReturnId()
        {
            return CreateDefaultBookingAsync().Result.Content.BookingId;
        }

        internal static async Task<ApiResponse<BookingId[]>> GetBookingIdsAsync(GetBookingIdsParams parameters)
        {
            return await apiClient.GetBookingIds(parameters);
        }
        internal static async Task<ApiResponse<BookingInfo>> PartialUpdateBookingAsync(int bookingId, string payload)
        {
            return await apiClient.PatchBooking(bookingId, payload, $"token={token}");
        }

        internal static async Task<ApiResponse<BookingInfo>> DeleteBookingAsync(int bookingId)
        {
            return await apiClient.DeleteBooking(bookingId, $"token={token}");
        }

        internal static BookingInfo GetDefaultBookingPayload()
        {
            return Utility.ParseJSon<BookingInfo>("DefaultBooking.json");
        }
    }
}
