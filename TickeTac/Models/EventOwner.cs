using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TickeTac.Models
{
    [Table("EventManager")]
    public class EventOwner
    {
        [Key]
        public UInt16 Id { get; set; }

        [Display(Name = "Nome do organizador ou razao social da empresa")]
        [StringLength(50, ErrorMessage = "O {0} deve possuir no máximo {1} caracteres!")]
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        public string Name { get; set; }

        [Display(Name = "CPF ou CNPJ ")]
        [Required(ErrorMessage = "Por favor, informe um CPF ou CNPJ válido.")]
        [StringLength(14)]
        public string CpfCnpj { get; set; }

        [Required]
        [Display(Name = "Evento")]
        public UInt16 EventId { get; set; }
        [ForeignKey("EventId")]
        public Event Event { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public AppUser User { get; set; }
    }
}