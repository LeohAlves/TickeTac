using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TickeTac.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "É necessário especificar uma cidade.")]
        [StringLength(70)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Estado")]

        public int StateId { get; set; }

        [ForeignKey("StateId")]
        public State State { get; set; }
    }
}