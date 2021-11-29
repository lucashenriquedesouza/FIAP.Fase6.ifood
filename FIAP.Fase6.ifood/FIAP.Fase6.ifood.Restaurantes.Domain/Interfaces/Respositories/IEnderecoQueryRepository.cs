using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories
{
    public interface IEnderecoQueryRepository
    {
        public Task<IEnumerable<Endereco>?> GetAll(Guid idRestaurante, bool? ativo = null);
        public Task<(Restaurante?, Endereco?)> Get(Guid id);
    }
}
