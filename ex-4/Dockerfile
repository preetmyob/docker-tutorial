FROM mcr.microsoft.com/dotnet/aspnet:6.0

RUN mkdir /app

COPY hello-api/bin/release/net6.0/publish/* /app

EXPOSE 80

CMD [ "dotnet", "/app/hello-api.dll"]