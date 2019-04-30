@ECHO OFF
ECHO start jupyter notebook 
docker run --rm -it -p 18888:8888 -v "C:/DevStudio/Docker/Project/Jupyter:/home/jovyan/work" --network jupyter_spark-network bigdatapoc/spark-jupyter:latest