FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AzureAD.Web/AzureAD.Web.csproj", "AzureAD.Web/"]
COPY ["AzureAD.Core/AzureAD.Core.csproj", "AzureAD.Core/"]
COPY ["AzureAD.Data/AzureAD.Data.csproj", "AzureAD.Data/"]
COPY ["AzureAD.Service/AzureAD.Service.csproj", "AzureAD.Service/"]
RUN dotnet restore "./AzureAD.Web/AzureAD.Web.csproj"
COPY . .
WORKDIR "/src/AzureAD.Web"
RUN dotnet build "./AzureAD.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./AzureAD.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AzureAD.Web.dll"]
