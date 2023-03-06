FROM mcr.microsoft.com/dotnet/aspnet:6.0

RUN mkdir /app

COPY bin/release/net6.0/publish/* /app

CMD [ "dotnet", "/app/myhelloworld.dll"]