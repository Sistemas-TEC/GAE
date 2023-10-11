using System.ComponentModel.DataAnnotations;

namespace GAE.Models
{
    public class Assembly
    {
        public int AssemblyId { get; set; }

        [DataType(DataType.Date)]
        public DateTime AssemblyDate { get; set; }
        [DataType(DataType.Time)]
        public DateTime AssemblyStartTime { get; set; }
        public DateTime AssemblyEndTime { get; set; }
        public int AssemblyStatus { get; set; }
        public string? AssociationId { get; set; }
        public string? DelegateId { get; set; }
        public int Participants { get; set; }
        public int AssemblyFacility {  get; set; }
    }
}

