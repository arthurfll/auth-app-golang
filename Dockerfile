FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY *.sln .
COPY ./*.csproj .

RUN dotnet restore

COPY . .

RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

# 📦 diretório persistente
VOLUME ["/app/data"]

EXPOSE 7000

ENV ASPNETCORE_URLS=http://0.0.0.0:7000

ENTRYPOINT ["dotnet", "core.dll"]
