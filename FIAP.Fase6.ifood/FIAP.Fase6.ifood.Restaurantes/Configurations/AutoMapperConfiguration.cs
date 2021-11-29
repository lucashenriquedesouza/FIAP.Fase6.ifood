using FIAP.Fase6.ifood.Restaurantes.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FIAP.Fase6.ifood.Restaurantes.Configurations
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile));
        }
    }
}
