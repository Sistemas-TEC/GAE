using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GAE.Models
{
    public class FacilityHasEquipment
    {
        [Key]
        [Column("FacilityHasEquipment")]
        public int FacilityHasEquipmentId { get; set; }

        [Required]
        public int FacilityIdFK { get; set; }

        [Required]
        public int EquipmentIdFK { get; set; }
    }
}
