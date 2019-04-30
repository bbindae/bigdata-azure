@ECHO OFF
ECHO start jupyter notebook 
docker run --rm -it -p 8888:8888 -v "D:/DevStudio/Docker/Project/Jupyter:/home/jovyan" --network jupyter_spark-network bigdatapoc/spark-jupyter:latest