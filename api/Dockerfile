FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env 
#build time
WORKDIR /app

EXPOSE 5007

ENV ASPNETCORE_URLS=http://+:5007

COPY api/ /app/api

RUN dotnet restore api/api.csproj

RUN dotnet publish api/api.csproj -c Release -o /app/out 

#Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 
WORKDIR /app
COPY --from=build-env /app/out ./


RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser
ENTRYPOINT ["dotnet", "api.dll"]