```shell
cd hello-api
dotnet publish -r release
dotnet run
#go to https://localhost:7209
cd .. 
podman build .  --tag my-hello-api:v1
podman run -itd -p 8081:80 my-hello-api:v1
podman logs  -t cont_id
podman container ps -a
podman container rm -f cont_id
```
