using System.Text.Json.Serialization;

namespace GAE.Models
{
    public class SessionData
    {
        [JsonPropertyName("id")]
        public int SessionDataId { get; set; }

        [JsonPropertyName("email")]
        public string? SessionDataEmail { get; set; }

        [JsonPropertyName("name")]
        public string? SessionDataName { get; set; }

        [JsonPropertyName("lastName")]
        public string? SessionDataLastName { get; set; }

        [JsonPropertyName("lastName2")]
        public string? SessionDataLastName2 { get; set; }

        [JsonPropertyName("Rol")]
        public int SessionDataRol { get; set; }
    }
}
