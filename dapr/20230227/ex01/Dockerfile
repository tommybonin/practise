FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ex01.csproj", "."]
RUN dotnet restore "./ex01.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "ex01.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ex01.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# ENTRYPOINT ["dapr"]
# CMD ["run", "--app-id", "ex01", "--dapr-http-port", "3000", "--app-port", "80", "dotnet", "ex01.dll"]
ENTRYPOINT ["dotnet", "ex01.dll"]