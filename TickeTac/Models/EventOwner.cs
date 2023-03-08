using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TickeTac.Models
{
    [Table("EventManager")]
    public class EventOwner
    {
        [Key]
        public uint Id { get; set; }

        [Required]
        [StringLength(14)]
        public string CpfCpj { get; set; }


    }
}