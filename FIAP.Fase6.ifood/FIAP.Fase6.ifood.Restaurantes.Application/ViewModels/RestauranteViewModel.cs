using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FIAP.Fase6.ifood.Restaurantes.Application.ViewModels
{
    public class RestauranteViewModel
    {
        [Key]
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "Nome Requerido")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "CNPJ Requerido")]
        [StringLength(14, MinimumLength = 14)]
        [DisplayName("CNPJ")]
        public string? CNPJ { get; set; }

        [Required(ErrorMessage = "Ativo Requerido")]
        public bool Ativo { get; set; } = true;
    }
}
