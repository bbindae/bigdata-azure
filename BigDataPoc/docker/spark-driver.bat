@ECHO OFF

ECHO Start a driver
docker run --rm -it -v "D:/DevStudio/Docker/Project/Spark:/project" --network docker_spark-network bigdatapoc/spark:latest /bin/bash