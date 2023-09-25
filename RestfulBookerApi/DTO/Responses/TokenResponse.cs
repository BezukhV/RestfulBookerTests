using System.Text.Json.Serialization;

namespace RestfulBookerApi.DTO.Responses
{
    public class TokenResponse
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
