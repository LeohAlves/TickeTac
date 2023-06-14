using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TickeTac.Models
{
    [Table("StatusEvent")]
    public class StatusEvent
    {
        [Key]
        public UInt16 Id { get; set; }
        
        [Required]
        [Display(Name = "Status do evento")]
        [StringLength(30)]
        public string Name { get; set; }
        
    }
}