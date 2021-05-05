# Ocelot API Gateway - Implemenation .NetCore 5.0
HxFood

## Whats Including In This Repository
We have implemented below **features over the run-aspnetcore-microservices repository**.

#### Catalog microservice which includes; 
* ASP.NET Core Web API application 
* REST API principles, CRUD operations
* **MongoDB database** connection and containerization
* Repository Pattern Implementation
* Swagger Open API implementation

#### API Gateway Ocelot Microservice
* Implement **API Gateways with Ocelot**
* Sample microservices/containers to reroute through the API Gateways
* Run multiple different **API Gateway/BFF** container types	
* The Gateway aggregation pattern in Shopping.Aggregator

#### Development
```csharp
docker-compose run
```
* Easiest to run using docker-compose is to build and start it.
* docker-compose build website to build the website image
* docker-compose up this will bring up the website, and you can go to your browser and go to container ip. example: (http://172.18.0.2/)
* docker build
* Example: docker build -t sampleshop-website:latest.

#### Maintainers
* **Hakan Taspinar** - hkntspnr@gmail.com 


...
Are you one of us? put your name here.
