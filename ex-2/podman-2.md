 
 ```shell
dotnet publish -c release 
dotnet bin/release/net6.0/publish/myhelloworld.dll
podman build .  --tag my-hello-world:v1
podman image ls
podman run my-hello-world:v1
podman container ps -a
for id in `podman image ls -q`; do podman image rm -f $id; 
for id in `podman container ps -aq`; do podman container rm ; done
```