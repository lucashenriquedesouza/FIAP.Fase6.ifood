using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP.Fase6.ifood.Restaurantes.Domain.Models
{
    public class Restaurante
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? CNPJ { get; set; }
        public bool Ativo { get; set; } = true;

        public List<Endereco> Enderecos { get; set; } = new();
        public List<Produto> Produtos { get; set; } = new();

    }
}
