using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories
{
    public interface IRestauranteCommandRepository
    {
        public Task<Guid> Create(Restaurante restaurante);
        public Task<Restaurante> Update(Restaurante restaurante);
        public Task<bool> Delete(Guid id);
    }
}
