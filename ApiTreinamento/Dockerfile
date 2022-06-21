#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ApiTreinamento/ApiTreinamento.csproj", "ApiTreinamento/"]
RUN dotnet restore "ApiTreinamento/ApiTreinamento.csproj"
COPY . .
WORKDIR "/src/ApiTreinamento"
RUN dotnet build "ApiTreinamento.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiTreinamento.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiTreinamento.dll"]