FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["src/Stock.Api/Stock.Api.csproj", "src/Stock.Api/"]
RUN dotnet restore "src/Stock.Api/Stock.Api.csproj"
COPY . .
WORKDIR "/src/src/Stock.Api"
RUN dotnet build "Stock.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Stock.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Stock.Api.dll"]