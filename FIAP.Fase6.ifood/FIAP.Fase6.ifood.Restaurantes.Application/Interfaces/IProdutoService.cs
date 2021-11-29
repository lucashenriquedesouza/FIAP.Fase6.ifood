using FIAP.Fase6.ifood.Restaurantes.Application.ViewModels;

namespace FIAP.Fase6.ifood.Restaurantes.Application.Interfaces
{
    public interface IProdutoService
    {
        Task<Guid> Create(Guid idRestaurante, ProdutoViewModel produtoViewModel);
        Task<bool> Delete(Guid id);
        Task<ProdutoViewModel?> Get(Guid id);
        Task<IEnumerable<ProdutoViewModel>?> GetAll(Guid idRestaurante, bool? ativo = null);
        Task<ProdutoViewModel> Update(Guid idRestaurante, ProdutoViewModel produtoViewModel);
    }
}