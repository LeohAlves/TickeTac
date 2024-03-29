using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace TickeTac.Models
{
    [Table("Event")]
    public class Event
    {
        [Key]
        public UInt16 Id { get; set; }
        [Display(Name = "Nome do evento")]
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [StringLength(100, ErrorMessage = "O nome do evento deve possuir no máximo 100 caracteres!")]
        public string Name { get; set; }

        [Display(Name = "Telefone para contato")]
        [Required(ErrorMessage = "É necessário informar um telefone!")]
        [StringLength(17, ErrorMessage = "Numero invalido")]
        [DisplayFormat(DataFormatString = "{0:(##)####-####}")]
        public string ContactPhone { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Required(ErrorMessage = "Informe o {0}")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }

        [Display(Name = "Data e horário de entrada do evento")]
        [Required(ErrorMessage = "Informe a data e horário de entrada do evento.")]
        public DateTime EventDateBegin { get; set; }

        [Display(Name = "Data e horário de saída do evento")]
        [Required(ErrorMessage = "Informe a data e horário de saída do evento.")]
        public DateTime EventDateEnd { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(600, ErrorMessage = "A descrição deve possuir no máximo 1000 caracteres.")]
        public string Description { get; set; }

        [Display(Name = "Imagem")]
        [StringLength(500, ErrorMessage = "Imagem invalida")]
        public string Image { get; set; }

        [Display(Name = "E-mail de contato")]
        [Required(ErrorMessage = "Informe um e-mail de contato.")]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido!")]
        public string ContactEmail { get; set; }

        [Display(Name = "Complemento")]
        [StringLength(300)]
        public string MoreInfo { get; set; }
        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "É necessário especificar um bairro.")]
        [StringLength(50)]
        public string District { get; set; }

        [Display(Name = "Logradouro")]
        [Required(ErrorMessage = "É necessário especificar um logradouro.")]
        [StringLength(50)]
        public string PublicSpace { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "É necessário especificar um CEP.")]
        [StringLength(15)]
        public string Cep { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Por favor, informe a categoria do evento")]
        public UInt16 CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }


        [Required]
        [Display(Name = "Status do evento")]
        public UInt16 StatusEventId { get; set; }
        [ForeignKey("StatusEventId")]
        public StatusEvent StatusEvent { get; set; }

        [Required(ErrorMessage = "Não pode estar em branco")]
        [Display(Name = "Sigla do Estado")]
        public int StateId { get; set; }
        [ForeignKey("StateId")]
        public State State { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "É necessário especificar uma cidade.")]
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }

        [Required]
        [Display(Name = "Organizador")]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public AppUser User { get; set; }

        public ICollection<EventReview> ReviewReceived { get; set; }
    }
}