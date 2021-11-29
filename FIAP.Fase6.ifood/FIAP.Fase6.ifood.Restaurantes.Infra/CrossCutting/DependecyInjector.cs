﻿using FIAP.Fase6.ifood.Restaurantes.Application.Interfeces;
using FIAP.Fase6.ifood.Restaurantes.Application.Services;
using FIAP.Fase6.ifood.Restaurantes.Domain.Interfaces.Respositories;
using FIAP.Fase6.ifood.Restaurantes.Infra.Repositories.InMemory;
using Microsoft.Extensions.DependencyInjection;

namespace FIAP.Fase6.ifood.Restaurantes.Infra.CrossCutting
{
    public static class DependecyInjector
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            //Services
            services.AddScoped<IRestauranteService, RestauranteService>();

            //Repositories
            services.AddScoped<IEnderecoCommandRepository, EnderecoCommandRepository>();
            services.AddScoped<IEnderecoQueryRepository, EnderecoQueryRepository>();
            services.AddScoped<IProdutoCommandRepository, ProdutoCommandRepository>();
            services.AddScoped<IProdutoQueryRepository, ProdutoQueryRepository>();
            services.AddScoped<IRestauranteCommandRepository, RestauranteCommandRepository>();
            services.AddScoped<IRestauranteQueryRepository, RestauranteQueryRepository>();

            return services;
        }
    }
}
