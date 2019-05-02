@ECHO OFF
ECHO start spark driver
docker run --rm -it -v "C:/DevStudio/Docker/Project/Jupyter:/home/jovyan/work" -e PYSPARK_SUBMIT_ARGS="--packages org.apache.spark:spark-avro_2.12:2.4.2 pyspark-shell" --network jupyter_spark-network bigdatapoc/spark-jupyter:latest /bin/bash