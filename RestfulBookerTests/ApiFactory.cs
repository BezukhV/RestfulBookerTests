using Refit;
using RestfulBookerApi;
using System.Text.Json;

namespace RestfulBookerTests
{
    internal static class ApiClientFactory
    {
        private static IRestfulBookerApi? instanse;

        internal static IRestfulBookerApi GetInstanse()
        {
            if (instanse is not null) return instanse;
            var serializtionOptions = JsonSerializerOptions.Default;
            instanse = RestService.For<IRestfulBookerApi>("https://restful-booker.herokuapp.com/"
                , new RefitSettings
                {
                    ContentSerializer = new SystemTextJsonContentSerializer(serializtionOptions)
                }
                );
            return instanse;
        }
    }
}
