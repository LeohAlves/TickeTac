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
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        [Display(Name = "Estado do evento")]

        public int StateId { get; set; }

        [ForeignKey("StateId")]
        public State State { get; set; }
    }
}