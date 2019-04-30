echo "start jupyter notebook"
docker run --rm -it -p 8888:8888 -v "/Users/hyukkim/DevStudio/Docker/Project/Jupyter:/home/jovyan/work" --network jupyter_spark-network bigdatapoc/spark-jupyter:latest