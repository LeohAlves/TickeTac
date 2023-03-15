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

        [Display(Name ="Sub Categoria")]
        [Required]
        public uint SubCategoryId { get; set; }
        [ForeignKey ("SubCategoryId")]
        public SubCategory SubCategory { get; set; }
    }
}