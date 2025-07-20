# Используем официальный .NET SDK для сборки
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Копируем файлы проекта
COPY . ./

# Восстанавливаем зависимости
RUN dotnet restore

# Собираем проект
RUN dotnet publish -c Release -o out

# Используем .NET Runtime для запуска
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Запускаем приложение
ENTRYPOINT ["dotnet", "MyTelegramBot.dll"]
