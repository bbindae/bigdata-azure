@ECHO OFF
ECHO start spark driver
docker run --rm -it -v "C:/DevStudio/Docker/Project/Jupyter:/home/jovyan" --network jupyter_spark-network bigdatapoc/spark-jupyter:latest /bin/bash