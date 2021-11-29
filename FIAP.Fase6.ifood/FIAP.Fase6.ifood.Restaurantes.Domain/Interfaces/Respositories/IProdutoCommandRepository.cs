using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories
{
    public interface IProdutoCommandRepository
    {
        public Task<Guid> Add(Guid IdRestaurante, Produto produto);
        public Task<Produto> Update(Produto produto);
        public Task<bool> Delete(Guid id);
    }
}
