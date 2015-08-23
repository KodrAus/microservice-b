FROM microsoft/aspnet

COPY project.json /app/
WORKDIR /app
RUN ["dnu", "restore"]
COPY . /app

EXPOSE 8004
ENTRYPOINT ["dnx", "project.json", "kestrel"]