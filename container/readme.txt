docker run --name soft -it ubuntu bash
docker cp jdk-7u80-linux-x64.tar.gz sisdiafx:/tmp
docker cp apache-tomcat-7.0.105.tar.gz sisdiafx:/tmp
instalar jdk e tomcat
apt update
apt install vim
setar JAVA_HOME
docker commit soft tomcat:1.0
docker build -t soft:1.0 .
docker images
docker run --name soft -p 8080:8080 soft:1.0
docker ps

