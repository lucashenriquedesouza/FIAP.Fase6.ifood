using FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories;
using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Infra.Repositories.InMemory
{
    internal class ProdutoCommandRepository : IProdutoCommandRepository
    {
        public async Task<Guid> Add(Guid IdRestaurante, Produto produto)
        {
            var Restaurante = InMemoryDatabase
                                .Restaurantes
                                .FirstOrDefault(x => x.Id == IdRestaurante && x.Ativo);

            if (Restaurante is null)
            {
                throw new Exception("Restaurnate inexistente");
            }

            produto.Id = Guid.NewGuid();

            Restaurante
                .Produtos
                .Add(produto);

            return await Task.FromResult(produto.Id);
        }

        public async Task<bool> Delete(Guid id)
        {
            var (RestauranteAux, ProdutoAux) = EnderecoQueryRepository.ObterEndereco(id);

            if (RestauranteAux is null || ProdutoAux is null)
            {
                return false;
            }

            var RestaurnateSearch = RestauranteAux
                                    .Produtos
                                    .Select((x, i) => new { index = i, val = x })
                                    .First(x => x.val.Id == id);

            RestauranteAux
                .Produtos[RestaurnateSearch.index]
                .Ativo = false;

            return await Task.FromResult(true);
        }

        public async Task<Produto> Update(Produto produto)
        {
            var (RestauranteAux, EnderecoAux) = EnderecoQueryRepository.ObterEndereco(produto.Id);

            if (RestauranteAux is null || EnderecoAux is null)
            {
                throw new Exception("Produto inexistente");
            }

            var RestaurnateSearch = RestauranteAux
                                    .Produtos
                                    .Select((x, i) => new { index = i, val = x })
                                    .First(x => x.val.Id == produto.Id);

            RestauranteAux
                .Produtos[RestaurnateSearch.index] = produto;

            return await Task.FromResult(produto);
        }
    }
}
