#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BeboerWeb.Api/BeboerWeb.Api.csproj", "BeboerWeb.Api/"]
COPY ["BeboerWeb.Api.Application/BeboerWeb.Api.Application.csproj", "BeboerWeb.Api.Application/"]
COPY ["BeboerWeb.Api.Domain/BeboerWeb.Api.Domain.csproj", "BeboerWeb.Api.Domain/"]
COPY ["BeboerWeb.Api.Persistence/BeboerWeb.Api.Persistence.csproj", "BeboerWeb.Api.Persistence/"]
RUN dotnet restore "BeboerWeb.Api/BeboerWeb.Api.csproj"
COPY . .
WORKDIR "/src/BeboerWeb.Api"
RUN dotnet build "BeboerWeb.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BeboerWeb.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BeboerWeb.Api.dll"]