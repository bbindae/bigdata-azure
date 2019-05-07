@ECHO OFF
ECHO start jupyter notebook 
docker run --rm -it -p 18888:8888 -v "D:/DevStudio/Docker/Project/Jupyter:/home/jovyan/work" -e PYSPARK_SUBMIT_ARGS="--packages org.apache.spark:spark-avro_2.12:2.4.2 pyspark-shell" --network jupyter_spark-network bigdatapoc/spark-jupyter:latest