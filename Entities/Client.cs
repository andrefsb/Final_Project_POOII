using System.ComponentModel.DataAnnotations;

namespace LetsMarket.Entities
{
    public class Client
    {
        [Display(Name = "Nome")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Documento")]
        [Required(ErrorMessage = "O Documento é Obrigatório")]
        [MinLength(11)]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [Display(Name = "Categoria")]
        public ClientCategory? Category { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Cpf}";
        }

    }
}