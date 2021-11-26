#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FIAP.Fase6.ifood.Restaurantes.Query/FIAP.Fase6.ifood.Restaurantes.Query.csproj", "FIAP.Fase6.ifood.Restaurantes.Query/"]
RUN dotnet restore "FIAP.Fase6.ifood.Restaurantes.Query/FIAP.Fase6.ifood.Restaurantes.Query.csproj"
COPY . .
WORKDIR "/src/FIAP.Fase6.ifood.Restaurantes.Query"
RUN dotnet build "FIAP.Fase6.ifood.Restaurantes.Query.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FIAP.Fase6.ifood.Restaurantes.Query.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FIAP.Fase6.ifood.Restaurantes.Query.dll"]