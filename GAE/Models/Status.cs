using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GAE.Models
{
    public class Status
    {
        [Key]
        [Column("StatusId")]
        public int StatusId { get; set; }
        [Required]
        public string StatusName { get; set; }
    }
}
