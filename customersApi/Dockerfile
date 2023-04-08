#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
ENV CONNECTION "Server=172.17.0.1;Port=33060;Database=bd_clientes;Uid=root;Pwd=secret;"

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["customersApi/customersApi.csproj", "customersApi/"]
RUN dotnet restore "customersApi/customersApi.csproj"
COPY . .
WORKDIR "/src/customersApi"
RUN dotnet build "customersApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "customersApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "customersApi.dll"]