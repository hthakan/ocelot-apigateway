#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SampleWebShop/SampleWebShop.csproj", "SampleWebShop/"]
RUN dotnet restore "SampleWebShop/SampleWebShop.csproj"
COPY . .
WORKDIR "/src/SampleWebShop"
RUN dotnet build "SampleWebShop.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SampleWebShop.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleWebShop.dll"]