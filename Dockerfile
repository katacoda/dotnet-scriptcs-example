FROM ocelotuproar/docker-alpine-scriptcs:0.16.1
EXPOSE 8080

RUN mkdir /src
WORKDIR /src

RUN scriptcs -install ScriptCs.WebApi2
COPY . /src

CMD ["/usr/bin/scriptcs/scriptcs", "start.csx"]
