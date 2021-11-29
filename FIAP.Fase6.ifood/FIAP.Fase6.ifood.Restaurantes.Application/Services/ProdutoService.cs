using AutoMapper;
using FIAP.Fase6.ifood.Restaurantes.Application.Interfaces;
using FIAP.Fase6.ifood.Restaurantes.Application.ViewModels;
using FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories;
using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Application.Services
{
    public class ProdutoService : IProdutoService
    {

        private readonly IMapper _mapper;

        private readonly IProdutoCommandRepository _produtoCommandRepository;
        private readonly IProdutoQueryRepository _produtoQueryRepository;

        public ProdutoService(IMapper mapper,
                              IProdutoCommandRepository produtoCommandRepository,
                              IProdutoQueryRepository produtoQueryRepository)
        {
            _mapper = mapper;

            _produtoCommandRepository = produtoCommandRepository;
            _produtoQueryRepository = produtoQueryRepository;
        }

        public async Task<Guid> Create(Guid idRestaurante, ProdutoViewModel produtoViewModel)
        {
            var Endereco = _mapper.Map<Produto>(produtoViewModel);

            return await _produtoCommandRepository.Add(idRestaurante, Endereco);
        }

        public async Task<bool> Delete(Guid id) => await _produtoCommandRepository.Delete(id);

        public async Task<ProdutoViewModel?> Get(Guid id) => _mapper.Map<ProdutoViewModel>(await _produtoQueryRepository.Get(id));

        public async Task<IEnumerable<ProdutoViewModel>?> GetAll(Guid idRestaurante, bool? ativo = null) => _mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoQueryRepository.GetAll(idRestaurante, ativo));

        public async Task<ProdutoViewModel> Update(Guid idRestaurante, ProdutoViewModel produtoViewModel)
        {
            var Produto = _mapper.Map<Produto>(produtoViewModel);

            return _mapper.Map<ProdutoViewModel>(await _produtoCommandRepository.Update(Produto));
        }
    }
}
