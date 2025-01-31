FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

COPY ./publish /app

ENTRYPOINT ["dotnet", "Cloud2025-arb.krav.dll"]
