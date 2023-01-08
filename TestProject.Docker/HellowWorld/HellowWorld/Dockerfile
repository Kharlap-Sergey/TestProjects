#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HellowWorld/HellowWorld.csproj", "HellowWorld/"]
RUN dotnet restore "HellowWorld/HellowWorld.csproj"
COPY . .
WORKDIR "/src/HellowWorld"
RUN dotnet build "HellowWorld.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HellowWorld.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HellowWorld.dll"]