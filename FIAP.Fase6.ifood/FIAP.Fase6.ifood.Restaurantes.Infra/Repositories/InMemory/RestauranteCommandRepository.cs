using FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories;
using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Infra.Repositories.InMemory
{
    internal class RestauranteCommandRepository : IRestauranteCommandRepository
    {
        public async Task<Guid> Create(Restaurante restaurante)
        {
            var Restaurante = InMemoryDatabase
                                .Restaurantes
                                .FirstOrDefault(x => x.CNPJ == restaurante.CNPJ && x.Ativo);

            if (Restaurante is not null)
            {
                throw new Exception($"{Restaurante.CNPJ} duplicado");
            }

            restaurante.Id = Guid.NewGuid();

            InMemoryDatabase
                .Restaurantes
                .Add(restaurante);

            return await Task.FromResult(restaurante.Id);
        }

        public async Task<bool> Delete(Guid id)
        {
            var RestaurnateSearch = InMemoryDatabase
                                    .Restaurantes
                                    .Select((x, i) => new { index = i, val = x })
                                    .FirstOrDefault(x => x.val.Id == id);

            if (RestaurnateSearch is null)
            {
                throw new Exception("Restaurante inexistente");
            }

            InMemoryDatabase
                .Restaurantes[RestaurnateSearch.index]
                .Ativo = false;

            return await Task.FromResult(true);
        }

        public async Task<Restaurante> Update(Restaurante restaurante)
        {
            var RestaurnateSearch = InMemoryDatabase
                                    .Restaurantes
                                    .Select((x, i) => new { index = i, val = x })
                                    .FirstOrDefault(x => x.val.Id == restaurante.Id);

            if (RestaurnateSearch is null)
            {
                throw new Exception("Restaurante inexistente");
            }

            InMemoryDatabase
                .Restaurantes[RestaurnateSearch.index] = restaurante;

            return await Task.FromResult(restaurante);
        }
    }
}
