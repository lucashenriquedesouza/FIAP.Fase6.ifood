using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories
{
    public interface IEnderecoCommandRepository
    {
        public Task<Guid> Add(Guid IdRestaurante, Endereco endereco);
        public Task<Endereco> Update(Endereco endereco);
        public Task<bool> Delete(Guid id);
    }
}
