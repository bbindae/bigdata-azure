FROM jupyter/pyspark-notebook

ENV PATH="${PATH}:/usr/local/spark/bin"

USER root
RUN mkdir /usr/local/spark/work
RUN mkdir /home/jovyan/examples
RUN chmod 777 /home/jovyan/examples

COPY RandomPi.ipynb /home/jovyan/examples/RandomPi.ipynb
COPY Spark-Cluster.ipynb /home/jovyan/examples/Spark-Cluster.ipynb

RUN chmod -R 777 /home/jovyan/examples

COPY start-master.sh /start-master.sh
COPY start-worker.sh /start-worker.sh

RUN sed -i 's/\r$//' /start-master.sh
RUN sed -i 's/\r$//' /start-worker.sh

RUN chmod +x /start-master.sh
RUN chmod +x /start-worker.sh