using System.Text.Json.Serialization;

namespace JWT.Auth.BlazorUi.Models
{  
    // Contains the error data returned by the Web API and the HttpMessageResponse
    public class Error
    {
        [JsonPropertyName("error")]
        public ErrorDetail detail { get; set; }
        public int statuscode { get; set; }
        public string reason { get; set; }
    }
}
