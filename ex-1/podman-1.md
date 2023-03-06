 
 ```shell
 mkdir dockerfile-1
 cd dockerfile-1
 echo echo  \"hello this a script running in a container\" >> myscript.sh
 ./myscript.sh
 chmod +x ./myscript.sh
 ./myscript.sh
 podman image ls
 podman image rm -f 1a
 podman build . --tag mycontainer:latest
 podman image ls
 podman run mycontainer
 podman build . --tag mycontainer ; podman run mycontainer
``` 