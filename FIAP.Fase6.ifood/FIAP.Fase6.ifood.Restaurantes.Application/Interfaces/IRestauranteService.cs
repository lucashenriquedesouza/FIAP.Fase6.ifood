using FIAP.Fase6.ifood.Restaurantes.Application.ViewModels;
using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Application.Interfaces
{
    public interface IRestauranteService
    {
        public Task<Guid> Create(RestauranteViewModel restauranteViewModel);
        public Task<RestauranteViewModel> Update(RestauranteViewModel restauranteViewModel);
        public Task<bool> Delete(Guid id);
        public Task<IEnumerable<RestauranteViewModel>?> GetAll(bool? ativo = null);
        public Task<RestauranteViewModel?> Get(Guid id);
    }
}
