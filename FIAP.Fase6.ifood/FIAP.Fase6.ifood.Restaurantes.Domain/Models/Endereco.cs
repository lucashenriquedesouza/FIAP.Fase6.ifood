namespace FIAP.Fase6.ifood.Restaurantes.Domain.Models
{
    public class Endereco
    {
        public Guid Id { get; set; }
        public string? Logradouro { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public int? Numero { get; set; }
        public string? Complemento { get; set; }
        public bool Ativo { get; set; }
        public bool Principal { get; set; }
    }
}
