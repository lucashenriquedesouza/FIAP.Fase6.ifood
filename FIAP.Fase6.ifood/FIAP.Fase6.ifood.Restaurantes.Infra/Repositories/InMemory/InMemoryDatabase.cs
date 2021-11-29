using FIAP.Fase6.ifood.Restaurantes.Domain.Models;

namespace FIAP.Fase6.ifood.Restaurantes.Infra.Repositories.InMemory
{
    public static class InMemoryDatabase
    {
        public static List<Restaurante> Restaurantes = new();
    }
}
