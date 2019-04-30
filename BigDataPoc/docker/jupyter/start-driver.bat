@ECHO OFF
ECHO start spark driver
docker run --rm -it -p 8888:8888 -v "D:/DevStudio/Docker/Project/Spark:/home/jovyan" --network jupyter_spark-network bigdatapoc/spark-jupyter:latest /bin/bash