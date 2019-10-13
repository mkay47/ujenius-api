using Newtonsoft.Json;

namespace ujenius_api.Models
{
    public class SendSMSResponse
    {
        [JsonProperty("message")]
       public string Message { get; set; }
    }
}
