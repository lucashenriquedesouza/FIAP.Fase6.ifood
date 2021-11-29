using AutoMapper;
using FIAP.Fase6.ifood.Restaurantes.Application.Interfeces;
using FIAP.Fase6.ifood.Restaurantes.Application.ViewModels;
using FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories;
using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Application.Services
{
    public class RestauranteService : IRestauranteService
    {

        private readonly IMapper _mapper;

        private readonly IRestauranteCommandRepository _restauranteCommandRepository;
        private readonly IRestauranteQueryRepository _restauranteQueryRepository;

        public RestauranteService(IMapper mapper,
                                  IRestauranteCommandRepository restauranteCommandRepository,
                                  IRestauranteQueryRepository restauranteQueryRepository)
        {
            _mapper = mapper;

            _restauranteCommandRepository = restauranteCommandRepository;
            _restauranteQueryRepository = restauranteQueryRepository;
        }

        public async Task<Guid> Create(RestauranteViewModel restauranteViewModel)
        {
            var Restaurante = _mapper.Map<Restaurante>(restauranteViewModel);

            return await _restauranteCommandRepository.Create(Restaurante);
        }

        public async Task<bool> Delete(Guid id) => await _restauranteCommandRepository.Delete(id);

        public async Task<RestauranteViewModel?> Get(Guid id) => _mapper.Map<RestauranteViewModel>(await _restauranteQueryRepository.Get(id));

        public async Task<IEnumerable<RestauranteViewModel>?> GetAll(bool? ativo = null) => _mapper.Map<IEnumerable<RestauranteViewModel>>(await _restauranteQueryRepository.GetAll(ativo));

        public async Task<RestauranteViewModel> Update(RestauranteViewModel restauranteViewModel)
        {
            var Restaurante = _mapper.Map<Restaurante>(restauranteViewModel);

            return _mapper.Map<RestauranteViewModel>(await _restauranteCommandRepository.Update(Restaurante));
        }
    }
}
