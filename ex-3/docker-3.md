```shell
cd hello-api
dotnet publish -r release
dotnet run
#go to https://localhost:7209
cd .. 
docker build .  --tag my-hello-api:v1
docker run -itd -p 8081:80 my-hello-api:v1
docker logs  -t cont_id
docker container ps -a
docker container rm -f cont_id
```
