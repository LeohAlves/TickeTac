using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace TickeTac.Models
{
    [Table("Review")]
    public class Review
    {
        [Key]
        public uint Id { get; set; }

        [Display(Name = "Nota")]
        public Byte Rating { get; set; }

        [Display(Name = "Avaliação")]
        [StringLength(2000, ErrorMessage = "A {0} deve possuir no máximo {1} caracteres")]
        public string ReviewText { get; set; }
        [Display(Name = "Data da Avaliação")]
        public DateTime ReviewDate { get; set; } = DateTime.Now;
        
        [Display(Name = "Usuario")]
        [Required]
        public uint ClientId { get; set; }
        [ForeignKey("ClientId")]
        [Display(Name = "Usuario")]
        public Client Client { get; set; }

        [Display(Name = "Evento")]
        [Required]
        public uint EventId { get; set; }
        [ForeignKey("EventId")]
        [Display(Name = "Evento")]
        public Event Event { get; set; }
    }
}