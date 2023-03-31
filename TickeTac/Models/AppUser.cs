using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace TickeTac.Models
{
    [Table("AppUser")]
    public class AppUser : IdentityUser
    {

        [Display(Name = "Nome do usuário")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres!")]
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        public string Name { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [StringLength(25, ErrorMessage = "A senha deve possuir no máximo 25 caracteres!")]
        [MinLength(8, ErrorMessage = "A senha deve possuir no mínimo 8 caracteres!")]
        public string Password { get; set; }

        [StringLength(400)]
        public string ProfilePicture { get; set; }

        public ICollection<EventReview> UserMadeReview { get; set; }
    }
}