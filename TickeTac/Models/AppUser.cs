using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace TickeTac.Models
{
    public class AppUser : IdentityUser
    {

        [Display(Name = "Nome do usuário")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres!")]
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        public string Name { get; set; }

        [StringLength(400)]
        public string ProfilePicture { get; set; }

        public ICollection<EventReview> UserMadeReview { get; set; }
    }
}