
# Етап 1: Компилиране на приложението
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY BookManager.csproj ./
RUN dotnet restore BookManager.csproj

COPY . .

RUN dotnet publish BookManager.csproj -c Release -o /app/publish --no-restore

# Етап 2: Стартиране на приложението
FROM mcr.microsoft.com/dotnet/aspnet:10.0

WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://0.0.0.0:10000
ENV ASPNETCORE_ENVIRONMENT=Production

EXPOSE 10000

ENTRYPOINT ["dotnet", "BookManager.dll"]
