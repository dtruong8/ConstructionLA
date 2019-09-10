# Table of Contents
- [Introduction](#intro)
- [Prerequisite](#prereq)
- [Instruction](#instruction)
- [References](#references)
- [License](#license)

## Introduction <a name="intro"></a>
This project will use Elastic Cloud on Kubernetes for easy deployment, security, and scalability of Elasticsearch cluster.



step one minikube start --cpus 4 --memory 6144

Set up Elasticsearch Cloud on Kubernetes

step one kubectl apply -f https://download.elastic.co/downloads/eck/0.9.0/all-in-one.yaml

step two kubectl apply -f ./quickstart-es.yml

kubectl get elasticsearch

step four kubectl apply -f ./quickstart-kibana.yml

kubectl get kibana

step five kubectl port-forward service/quickstart-kb-http 5601

https://localhost:5601
