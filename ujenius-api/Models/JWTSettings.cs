using Newtonsoft.Json;

namespace ujenius_api.Models
{
    public class JWTSettings
    {
        [JsonProperty("secret_key")]
        public string SecretKey { get; set; }
    }
}