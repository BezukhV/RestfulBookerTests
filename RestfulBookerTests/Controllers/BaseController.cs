using RestfulBookerApi;
using RestfulBookerApi.DTO.Requests;

namespace RestfulBookerTests.Controllers
{
    internal class BaseController
    {
        internal static IRestfulBookerApi apiClient = ApiClientFactory.GetInstanse();
        internal static string token = GetToken().Result;

        private static async Task<string> GetToken()
        {
            var tokentResponse = await apiClient.CreateToken(new User("admin", "password123"));
            return tokentResponse.Token;
        }
    }
}
