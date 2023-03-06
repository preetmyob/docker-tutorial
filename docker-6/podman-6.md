 ```shell
 podman pull acantril/containerofcats
podman image ls
podman image inspect img_id
podman run -p 8081:80 img_id
podman run -p 8081:80 acantril/containerofcats
podman container ps
podman run -p 8081:80 -d acantril/containerofcats 
podman container ps -a
podman container port img_id
podman container exec -it img_id ps -aux
podman container exec -it img_id sh
podman ps
podman container restart  img_id 
podman container logs 15 -t
podman container rm 15 36
podman image ls
podman image rm -f cont_id
podman pull containerofcats
podman login
podman pull containerofcats
podman pull acantril/containerofcats
podman image ls
podman image inspect cont_id
podman run -p 8081:80 cont_id
podman run -p 8081:80 -d acantril/containerofcats 
podman container port img_id
podman container exec -it img_id ps -aux
podman container exec -it img_id sh
podman container logs 15 -t
podman image rm -f cont_id
```
