using System.Text.Json.Serialization;
namespace GAE.Models
{
    public class Organization
    {
        [JsonPropertyName("id")]
        public long id { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("emailNavigation")]
        public object EmailNavigation { get; set; } // Since
    }
}
