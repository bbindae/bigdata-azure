@ECHO OFF
ECHO start building docker file and image name will be bigdatapoc/spark-jupyter:latest
docker build . -t bigdatapoc/spark-jupyter:latest
