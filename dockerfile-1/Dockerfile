FROM alpine:latest

LABEL name=myfirstcontainer

COPY ./myscript.sh /usr/bin

RUN chmod +x /usr/bin/myscript.sh

CMD [ "myscript.sh" ]