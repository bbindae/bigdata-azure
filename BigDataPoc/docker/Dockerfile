FROM openjdk:8-alpine

RUN apk --update add wget tar bash
#RUN apk upgrade
#RUN apk update
#RUN apt-get install python3
#RUN apk add --no-cache python3=3.7.3
RUN wget http://apache.mirror.anlx.net/spark/spark-2.4.2/spark-2.4.2-bin-hadoop2.7.tgz
RUN tar -xzf spark-2.4.2-bin-hadoop2.7.tgz && \
    mv spark-2.4.2-bin-hadoop2.7 /spark && \
    rm spark-2.4.2-bin-hadoop2.7.tgz

ENV PATH="${PATH}:/spark/bin:/usr/bin"
ENV PYSPARK_PYTHON="/usr/bin/python3"

RUN mkdir /project

COPY start-master.sh /start-master.sh
COPY start-worker.sh /start-worker.sh

