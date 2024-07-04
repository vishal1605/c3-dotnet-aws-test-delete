FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["first-web-api-dot-net/first-web-api-dot-net.csproj", "first-web-api-dot-net/"]
RUN dotnet restore "./first-web-api-dot-net/first-web-api-dot-net.csproj"
COPY . .
WORKDIR "/src/first-web-api-dot-net"
RUN dotnet build "./first-web-api-dot-net.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./first-web-api-dot-net.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "first-web-api-dot-net.dll"]