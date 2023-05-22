using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TickeTac.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nao Pode estar em branco")]
        [Display(Name ="Sigla Estado")]
        [StringLength(2, ErrorMessage =" 2 caracters no maximo")]
        public string Name { get; set; }
    }
}