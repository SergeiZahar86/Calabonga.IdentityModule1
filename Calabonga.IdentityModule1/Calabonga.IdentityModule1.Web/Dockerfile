#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Calabonga.IdentityModule1/Calabonga.IdentityModule1.Web/Calabonga.IdentityModule1.Web.csproj", "Calabonga.IdentityModule1/Calabonga.IdentityModule1.Web/"]
COPY ["Calabonga.IdentityModule1/Calabonga.IdentityModule1.Core/Calabonga.IdentityModule1.Core.csproj", "Calabonga.IdentityModule1/Calabonga.IdentityModule1.Core/"]
COPY ["Calabonga.IdentityModule1/Calabonga.IdentityModule1.Data/Calabonga.IdentityModule1.Data.csproj", "Calabonga.IdentityModule1/Calabonga.IdentityModule1.Data/"]
COPY ["Calabonga.IdentityModule1/Calabonga.IdentityModule1.Entities/Calabonga.IdentityModule1.Entities.csproj", "Calabonga.IdentityModule1/Calabonga.IdentityModule1.Entities/"]
RUN dotnet restore "Calabonga.IdentityModule1/Calabonga.IdentityModule1.Web/Calabonga.IdentityModule1.Web.csproj"
COPY . .
WORKDIR "/src/Calabonga.IdentityModule1/Calabonga.IdentityModule1.Web"
RUN dotnet build "Calabonga.IdentityModule1.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Calabonga.IdentityModule1.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Calabonga.IdentityModule1.Web.dll"]