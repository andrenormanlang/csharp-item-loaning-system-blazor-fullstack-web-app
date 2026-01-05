# Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# copy csproj and restore
COPY ComicBooksLoanAppAPI/ComicBooksLoanAppAPI.csproj ComicBooksLoanAppAPI/
RUN dotnet restore ComicBooksLoanAppAPI/ComicBooksLoanAppAPI.csproj

# copy everything else and publish
COPY . .
RUN dotnet publish ComicBooksLoanAppAPI/ComicBooksLoanAppAPI.csproj -c Release -o /app/publish /p:UseAppHost=false

# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Render expects the service to listen on $PORT.
ENV ASPNETCORE_URLS=http://+:${PORT:-8080}

COPY --from=build /app/publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "ComicBooksLoanAppAPI.dll"]
