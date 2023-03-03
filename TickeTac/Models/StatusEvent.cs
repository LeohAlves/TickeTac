using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TickeTac.Models
{
    [Table("StatusEvent")]
    public class StatusEvent
    {
        [Key]
        public uint Id { get; set; }
        [Required]
        [Display(Name = "Status do evento")]
        [StringLength(30)]
        public string Name { get; set; }
        
    }
}