# Table of Contents
- [Introduction](#intro)
- [Prerequisite](#prereq)
- [Instruction](#instruction)
- [References](#references)
- [License](#license)

## Introduction <a name="intro"></a>
This project will use Elastic Cloud on Kubernetes for easy deployment, security, and scalability of Elasticsearch cluster.

## Prerequisite <a name="prereq"></a>
Recommended Minikube Configuration
- cpu core - 4
- memory - 6144 mb
- storage - 10GB

## Instruction <a name="instruction"></a>

Set up Elasticsearch Cloud on Kubernetes

1. kubectl apply -f https://download.elastic.co/downloads/eck/0.9.0/all-in-one.yaml

2. kubectl apply -f ./quickstart-es.yml

- kubectl get elasticsearch

3. kubectl apply -f ./quickstart-kibana.yml

- kubectl get kibana

4. kubectl port-forward service/quickstart-kb-http 5601

- https://localhost:5601
