using System.Text.Json.Serialization;

namespace GAE.Models
{
    public class UserLogged
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("Rol")]
        public int Rol { get; set; }
    }
}
