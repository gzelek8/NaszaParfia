FROM mcr.microsoft.com/dotnet/aspnet:8.0-preview-alpine AS base
ARG BUILD_SOURCEVERSION
ARG BUILD_BUILDID
ARG BUILD_BUILDNUMBER

RUN apk update && apt upgrade && apk info musl

WORKDIR /app
EXPOSE 5000
ENV ASPNETCORE_URLS=http://*:5000

COPY ./out .

RUN addgroup devsgroup --gid 10002 && adduser devuser -D -u 10001 -G devsgroup && chown -R 10001:10001 /app

USER 10001

ENTRYPOINT ["dotnet", "NaszaParafia.API.dll"]