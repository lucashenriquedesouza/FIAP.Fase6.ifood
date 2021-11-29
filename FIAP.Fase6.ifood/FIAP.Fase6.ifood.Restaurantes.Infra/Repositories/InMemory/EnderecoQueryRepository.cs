using FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories;
using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Infra.Repositories.InMemory
{
    public class EnderecoQueryRepository : IEnderecoQueryRepository
    {
        public async Task<(Restaurante?, Endereco?)> Get(Guid id) => await Task.FromResult(ObterEndereco(id));

        public async Task<IEnumerable<Endereco>?> GetAll(Guid idRestaurante, bool? ativo = null) => ativo is null ? await Task.FromResult(InMemoryDatabase
                                                                                                                                         .Restaurantes
                                                                                                                                         .FirstOrDefault(x => x.Id == idRestaurante)
                                                                                                                                         ?.Enderecos)
                                                                                                                  : await Task.FromResult(InMemoryDatabase
                                                                                                                                          .Restaurantes
                                                                                                                                          .FirstOrDefault(x => x.Id == idRestaurante)
                                                                                                                                          ?.Enderecos
                                                                                                                                          ?.Where(x => x.Ativo == ativo));


        public static (Restaurante?, Endereco?) ObterEndereco(Guid idEndereco)
        {
            foreach (var restaurante in InMemoryDatabase.Restaurantes.Where(x => x.Ativo))
            {
                foreach (var endereco in restaurante.Enderecos)
                {
                    if (endereco.Id == idEndereco && endereco.Ativo) return (restaurante, endereco);
                }
            }
            return (null, null);
        }
    }
}
