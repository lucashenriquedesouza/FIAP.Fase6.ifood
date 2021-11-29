using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.Fase6.ifood.Restaurantes.Domain.Models
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Categoria { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
    }
}
