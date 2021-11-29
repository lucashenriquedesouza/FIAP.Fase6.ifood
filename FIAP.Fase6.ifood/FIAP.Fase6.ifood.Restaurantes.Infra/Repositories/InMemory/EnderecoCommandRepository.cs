using FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories;
using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Infra.Repositories.InMemory
{
    internal class EnderecoCommandRepository : IEnderecoCommandRepository
    {
        public async Task<Guid> Add(Guid IdRestaurante, Endereco endereco)
        {
            var Restaurante = InMemoryDatabase
                                .Restaurantes
                                .FirstOrDefault(x => x.Id == IdRestaurante && x.Ativo);

            if (Restaurante is null)
            {
                throw new Exception("Restaurnate inexistente");
            }

            endereco.Id = Guid.NewGuid();

            Restaurante
                .Enderecos
                .Add(endereco);

            return await Task.FromResult(endereco.Id);
        }

        public async Task<bool> Delete(Guid id)
        {
            var (RestauranteAux, EnderecoAux) = EnderecoQueryRepository.ObterEndereco(id);

            if (RestauranteAux is null || EnderecoAux is null)
            {
                return false;
            }

            var RestaurnateSearch = RestauranteAux
                                    .Enderecos
                                    .Select((x, i) => new { index = i, val = x })
                                    .First(x => x.val.Id == id);

            RestauranteAux
                .Enderecos[RestaurnateSearch.index]
                .Ativo = false;

            return await Task.FromResult(true);
        }

        public async Task<Endereco> Update(Endereco endereco)
        {
            var (RestauranteAux, EnderecoAux) = EnderecoQueryRepository.ObterEndereco(endereco.Id);

            if (RestauranteAux is null || EnderecoAux is null)
            {
                throw new Exception("Endereco inexistente");
            }

            var RestaurnateSearch = RestauranteAux
                                    .Enderecos
                                    .Select((x, i) => new { index = i, val = x })
                                    .First(x => x.val.Id == endereco.Id);

            RestauranteAux
                .Enderecos[RestaurnateSearch.index] = endereco;

            return await Task.FromResult(endereco);
        }

    }
}
