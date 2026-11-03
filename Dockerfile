
# Етап 1: Компилиране на приложението
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

# Копиране на проектния файл от подпапката BookManager
COPY BookManager/BookManager.csproj BookManager/

# Възстановяване на NuGet пакетите
RUN dotnet restore BookManager/BookManager.csproj

# Копиране на всички файлове
COPY . .

# Компилиране и публикуване на приложението
RUN dotnet publish BookManager/BookManager.csproj -c Release -o /app/publish --no-restore

# Етап 2: Стартиране на приложението
FROM mcr.microsoft.com/dotnet/aspnet:10.0

WORKDIR /app

# Копиране на публикуваното приложение
COPY --from=build /app/publish .

# Настройки за Render
ENV ASPNETCORE_URLS=http://0.0.0.0:10000
ENV ASPNETCORE_ENVIRONMENT=Production

EXPOSE 10000

# Стартиране на BookManager
ENTRYPOINT ["dotnet", "BookManager.dll"]
