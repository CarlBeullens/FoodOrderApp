FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["FoodOrderApp.csproj", "./"]
RUN dotnet restore "FoodOrderApp.csproj"
COPY . .
# Force Razor compilation and CSS generation
RUN dotnet build "FoodOrderApp.csproj" -c Release -o /app/build /p:UseRazorSourceGenerator=true

FROM build AS publish
RUN dotnet publish "FoodOrderApp.csproj" -c Release -o /app/publish /p:UseAppHost=false /p:UseRazorSourceGenerator=true

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FoodOrderApp.dll"]