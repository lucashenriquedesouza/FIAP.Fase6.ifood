using FIAP.Fase6.ifood.Restaurantes.Application.ViewModels;

namespace FIAP.Fase6.ifood.Restaurantes.Application.Interfaces
{
    public interface IEnderecoService
    {
        public Task<Guid> Create(Guid idRestaurante, EnderecoViewModel enderecoViewModel);
        public Task<bool> Delete(Guid id);
        public Task<EnderecoViewModel?> Get(Guid id);
        public Task<IEnumerable<EnderecoViewModel>?> GetAll(Guid idRestaurante, bool? ativo = null);
        public Task<EnderecoViewModel> Update(Guid idRestaurante, EnderecoViewModel enderecoViewModel);
    }
}