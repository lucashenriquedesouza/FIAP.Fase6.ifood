using FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories;
using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Infra.Repositories.InMemory
{
    public class RestauranteQueryRepository : IRestauranteQueryRepository
    {
        public async Task<Restaurante?> Get(Guid id) => await Task.FromResult(InMemoryDatabase
                                                                                .Restaurantes
                                                                                .FirstOrDefault(x => x.Id == id));

        public async Task<IEnumerable<Restaurante>?> GetAll(bool? ativo = null) => ativo is null ? await Task.FromResult(InMemoryDatabase
                                                                                                                         .Restaurantes)
                                                                                                 : await Task.FromResult(InMemoryDatabase
                                                                                                                         .Restaurantes
                                                                                                                         .Where(x => x.Ativo == ativo));
    }
}
