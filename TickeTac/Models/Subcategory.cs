using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TickeTac.Models
{
    [Table("SubCategory")]
    public class SubCategory
    {
       [Key]
        public uint Id { get; set; }

        [Display(Name = "Subcategoria")]
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [StringLength(20)]
        public string Nome { get; set; }  
    }
}