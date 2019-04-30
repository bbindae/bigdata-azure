echo "start spark cluster with 3 workers..."
docker-compose -f .././docker-compose.yml up --build --scale spark-worker=3