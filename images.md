 ```shell
 docker pull acantril/containerofcats
docker image ls
docker image inspect img_id
docker run -p 8081:80 img_id
docker run -p 8081:80 acantril/containerofcats
docker container ps
docker run -p 8081:80 -d acantril/containerofcats 
docker container ps -a
docker container port img_id
docker container exec -it img_id ps -aux
docker container exec -it img_id sh
docker ps
docker container restart  img_id 
docker container logs 15 -t
docker container rm 15 36
docker image ls
docker image rm -f cont_id
docker pull containerofcats
docker login
docker pull containerofcats
docker pull acantril/containerofcats
docker image ls
docker image inspect cont_id
docker run -p 8081:80 cont_id
docker run -p 8081:80 -d acantril/containerofcats 
docker container port img_id
docker container exec -it img_id ps -aux
docker container exec -it img_id sh
docker container logs 15 -t
docker image rm -f cont_id
```