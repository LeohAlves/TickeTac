using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TickeTac.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public UInt16 Id { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [StringLength(20)]
        public string Name { get; set; }
        
        [StringLength(600)]
        public string Img { get; set; } 
    }
}