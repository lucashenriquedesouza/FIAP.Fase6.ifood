using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.Fase6.ifood.Restaurantes.Application.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome Requerido")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string? Logradouro { get; set; }

        [Required(ErrorMessage = "Nome Requerido")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string? Cidade { get; set; }

        [Required(ErrorMessage = "Nome Requerido")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string? Bairro { get; set; }

        [Required(ErrorMessage = "Nome Requerido")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public int? Numero { get; set; }

        [Required(ErrorMessage = "Nome Requerido")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string? Complemento { get; set; }

        [Required(ErrorMessage = "Nome Requerido")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "Nome Requerido")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public bool Principal { get; set; }
    }
}
