using Newtonsoft.Json;

namespace ujenius_api.Models
{
    public class Farmer
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }

        [JsonProperty("speciality")]
        public string Speciality { get; set; }
    }
}
