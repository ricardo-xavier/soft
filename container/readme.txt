docker run --name soft -it ubuntu bash
docker cp apache-tomcat-9.0.37.tar.gz soft:/tmp
apt update
apt install vim
apt install default-jdk

docker commit soft tomcat9jdk11:1.0
docker build -t soft:1.0 .
docker images
docker run --name soft -p 8080:8080 soft:1.0
docker ps

