using AutoMapper;
using FIAP.Fase6.ifood.Restaurantes.Application.ViewModels;
using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<RestauranteViewModel, Restaurante>().ReverseMap();

            CreateMap<ProdutoViewModel, Produto>().ReverseMap();

            CreateMap<EnderecoViewModel, Endereco>().ReverseMap();
        }
    }
}
