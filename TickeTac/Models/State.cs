using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TickeTac.Models
{
    [Table("State")]
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        [Display(Name ="Sigla do Estado")]
        [StringLength(2, ErrorMessage ="2 caracteres no máximo")]
        public string Name { get; set; }
    }
}