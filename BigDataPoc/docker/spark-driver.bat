@ECHO OFF

ECHO Start a driver
docker run --rm -it -v "C:/DevStudio/Projects/Spark:/project" --network docker_spark-network bigdatapoc/spark:latest /bin/bash