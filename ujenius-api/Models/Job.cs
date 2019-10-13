using Newtonsoft.Json;

namespace ujenius_api.Models
{
    public class Job
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("posted_by")]
        public string PostedBy { get; set; }

        [JsonProperty("assisted_by")]
        public string AssistedBy { get; set; }

    }
}
