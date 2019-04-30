FROM jupyter/pyspark-notebook

ENV PATH="${PATH}:/usr/local/spark/bin"

USER root
RUN mkdir /usr/local/spark/work

COPY start-master.sh /start-master.sh
COPY start-worker.sh /start-worker.sh