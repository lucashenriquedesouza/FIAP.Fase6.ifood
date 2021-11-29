using FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories;
using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Infra.Repositories.InMemory
{
    public class ProdutoQueryRepository : IProdutoQueryRepository
    {
        public async Task<(Restaurante?, Produto?)> Get(Guid id) => await Task.FromResult(ObterProduto(id));

        public async Task<IEnumerable<Produto>?> GetAll(Guid idRestaurante, bool? ativo = null) => ativo is null ? await Task.FromResult(InMemoryDatabase
                                                                                                                                         .Restaurantes
                                                                                                                                         .FirstOrDefault(x => x.Id == idRestaurante)
                                                                                                                                         ?.Produtos)
                                                                                                                 : await Task.FromResult(InMemoryDatabase
                                                                                                                                         .Restaurantes
                                                                                                                                         .FirstOrDefault(x => x.Id == idRestaurante)
                                                                                                                                         ?.Produtos
                                                                                                                                         ?.Where(x => x.Ativo == ativo));

        public static (Restaurante?, Produto?) ObterProduto(Guid idProduto)
        {
            foreach (var restaurante in InMemoryDatabase.Restaurantes.Where(x => x.Ativo))
            {
                foreach (var produto in restaurante.Produtos)
                {
                    if (produto.Id == idProduto && produto.Ativo) return (restaurante, produto);
                }
            }
            return (null, null);
        }
    }
}
