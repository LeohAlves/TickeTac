using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace TickeTac.Models
{
    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage = "O campo não pode ser vazio!")]   
        [Display(Name = "Nome do usuário")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres!")]
        public string Name { get; set; }

        [StringLength(400)]
        public string ProfilePicture { get; set; }
        public ICollection<EventReview> UserMadeReview { get; set; }
    }
}