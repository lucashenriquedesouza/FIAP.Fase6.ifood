using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FIAP.Fase6.ifood.Restaurantes.Application.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Logradouro Requerido")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Logradouro")]
        public string? Logradouro { get; set; }

        [Required(ErrorMessage = "Cidade Requerido")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Cidade")]
        public string? Cidade { get; set; }

        [Required(ErrorMessage = "Bairro Requerido")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Bairro")]
        public string? Bairro { get; set; }

        [Required(ErrorMessage = "Numero Requerido")]
        [DisplayName("Numero")]
        public int? Numero { get; set; }

        [Required(ErrorMessage = "Complemento Requerido")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Complemento")]
        public string? Complemento { get; set; }

        [Required(ErrorMessage = "Ativo Requerido")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "Principal Requerido")]
        public bool Principal { get; set; }
    }
}
