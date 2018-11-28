FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY X.MAX.EntityGenerator/X.MAX.EntityGenerator.csproj X.MAX.EntityGenerator/
RUN dotnet restore X.MAX.EntityGenerator/X.MAX.EntityGenerator.csproj
COPY . .
WORKDIR /src/X.MAX.EntityGenerator
RUN dotnet build X.MAX.EntityGenerator.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish X.MAX.EntityGenerator.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "X.MAX.EntityGenerator.dll"]
