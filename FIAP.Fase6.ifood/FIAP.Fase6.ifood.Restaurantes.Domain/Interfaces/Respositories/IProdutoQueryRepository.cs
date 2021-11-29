using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories
{
    public interface IProdutoQueryRepository
    {
        public Task<IEnumerable<Produto>?> GetAll(Guid idRestaurante, bool? ativo = null);
        public Task<(Restaurante?, Produto?)> Get(Guid id);
    }
}
