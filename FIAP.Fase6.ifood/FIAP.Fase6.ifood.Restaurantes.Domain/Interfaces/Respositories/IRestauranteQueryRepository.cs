using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories
{
    public interface IRestauranteQueryRepository
    {
        public Task<IEnumerable<Restaurante>?> GetAll(bool? ativo = null);
        public Task<Restaurante?> Get(Guid Id);
    }
}
