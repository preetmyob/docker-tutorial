 
 ```shell
 dotnet publish -c release 
dotnet bin/release/net6.0/publish/myhelloworld.dll
docker build .  --tag my-hello-world:v1
docker image ls
docker run my-hello-world:v1
docker container ps -a
for id in `docker image ls -q`; do docker image rm -f $id; 
for id in `docker container ps -aq`; do docker container rm ; done
```