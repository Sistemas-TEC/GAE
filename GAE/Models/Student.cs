using System.Text.Json.Serialization;

namespace GAE.Models
{
    public class Student
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("isExemptFromPrintingCosts")]
        public bool IsExemptFromPrintingCosts { get; set; }

        [JsonPropertyName("degreeId")]
        public int DegreeId { get; set; }

        [JsonPropertyName("degreeName")]
        public string DegreeName { get; set; }
    }
}
