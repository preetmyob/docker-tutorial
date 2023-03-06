 
 ```shell
 mkdir dockerfile-1
 cd dockerfile-1
 echo echo  \"hello this a script running in a container\" >> myscript.sh
 ./myscript.sh
 chmod +x ./myscript.sh
 ./myscript.sh
 docker image ls
 docker image rm -f 1a
 docker build . --tag mycontainer:latest
 docker image ls
 docker run mycontainer
 docker build . --tag mycontainer ; docker run mycontainer
``` 