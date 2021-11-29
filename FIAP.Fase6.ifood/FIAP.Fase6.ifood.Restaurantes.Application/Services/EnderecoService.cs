using AutoMapper;
using FIAP.Fase6.ifood.Restaurantes.Application.Interfaces;
using FIAP.Fase6.ifood.Restaurantes.Application.ViewModels;
using FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories;
using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Application.Services
{
    public class EnderecoService : IEnderecoService
    {

        private readonly IMapper _mapper;

        private readonly IEnderecoCommandRepository _enderecoCommandRepository;
        private readonly IEnderecoQueryRepository _enderecoQueryRepository;

        public EnderecoService(IMapper mapper,
                               IEnderecoCommandRepository enderecoCommandRepository,
                               IEnderecoQueryRepository enderecoQueryRepository)
        {
            _mapper = mapper;

            _enderecoCommandRepository = enderecoCommandRepository;
            _enderecoQueryRepository = enderecoQueryRepository;
        }

        public async Task<Guid> Create(Guid idRestaurante, EnderecoViewModel enderecoViewModel)
        {
            var Endereco = _mapper.Map<Endereco>(enderecoViewModel);

            return await _enderecoCommandRepository.Add(idRestaurante, Endereco);
        }

        public async Task<bool> Delete(Guid id) => await _enderecoCommandRepository.Delete(id);

        public async Task<EnderecoViewModel?> Get(Guid id) => _mapper.Map<EnderecoViewModel>(await _enderecoQueryRepository.Get(id));

        public async Task<IEnumerable<EnderecoViewModel>?> GetAll(Guid idRestaurante, bool? ativo = null) => _mapper.Map<IEnumerable<EnderecoViewModel>>(await _enderecoQueryRepository.GetAll(idRestaurante, ativo));

        public async Task<EnderecoViewModel> Update(Guid idRestaurante, EnderecoViewModel enderecoViewModel)
        {
            var Endereco = _mapper.Map<Endereco>(enderecoViewModel);

            return _mapper.Map<EnderecoViewModel>(await _enderecoCommandRepository.Update(Endereco));
        }
    }
}
