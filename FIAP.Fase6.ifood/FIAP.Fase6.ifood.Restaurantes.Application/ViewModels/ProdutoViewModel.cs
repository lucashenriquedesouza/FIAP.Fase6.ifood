using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FIAP.Fase6.ifood.Restaurantes.Application.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome Requerido")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Descrição Requerida")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Descrição")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Categoria Requerida")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Categoria")]
        public string? Categoria { get; set; }

        [Required(ErrorMessage = "Valor Requerido")]
        [Range(0.01,9999999.99, ErrorMessage = "{0} deve estar entre {1} e {2}.")]
        [DisplayName("Valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Ativo Requerido")]
        public bool Ativo { get; set; } = true;
    }
}
