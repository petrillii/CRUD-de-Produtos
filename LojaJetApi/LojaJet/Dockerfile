#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LojaJet/LojaJet.csproj", "LojaJet/"]
RUN dotnet restore "LojaJet/LojaJet.csproj"
COPY . .
WORKDIR "/src/LojaJet"
RUN dotnet build "LojaJet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LojaJet.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LojaJet.dll"]