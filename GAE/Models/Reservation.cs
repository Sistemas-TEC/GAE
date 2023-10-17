using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GAE.Models
{
    public class Reservation
    {
        [Key]
        [Column("reservationId")]
        public int ReservationId { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime ReservationDate { get; set; }
        [Required]
        [Column(TypeName = "Time")]
        public TimeSpan ReservationStartTime { get; set; }
        [Required]
        [Column(TypeName = "Time")]
        public TimeSpan ReservationEndTime { get; set; }
        [Required]
        public int ReservationStatusId{ get; set; }
        [Required]
        public int asociationId { get; set; }

        public int delegateId { get; set; }
        [Required]
        public int participants { get; set; }

        [NotMapped]
        public UserAPIModel Person { get; set; }

    }
}