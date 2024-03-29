using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TickeTac.Models
{
    [Table("EventReviews")]
    public class EventReview
    {
        [Key]
        public UInt16 Id { get; set; }
        
        public UInt16 EventId { get; set; }
        [ForeignKey("EventId")]
        public Event Event { get; set; }
        
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public AppUser User { get; set; }

        [Display(Name = "Nota")]
        public Byte Rating { get; set; }

        [Display(Name = "Avaliação")]
        [StringLength(2000, ErrorMessage = "A {0} deve possuir no máximo {1} caracteres")]
        public string ReviewText { get; set; }
        [Display(Name = "Data da Avaliação")]
        public DateTime ReviewDate { get; set; } = DateTime.Now;

    }
}