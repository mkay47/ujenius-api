using Newtonsoft.Json;

namespace ujenius_api.Models
{
    public class SendSMSRequest
    {
        [JsonProperty("number")]
        public string Number { get; set; }
        
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
