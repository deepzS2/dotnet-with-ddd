# .NET WebApi With DDD
Creating a basic WebApi using Domain-driven Design concepts and Docker.

## What is Domain-driven Design?
Domain-driven design (DDD) is a software design approach focusing on modelling software to match a domain according to input from that domain's experts.
In terms of object-oriented programming it means that the structure and language of software code (class names, class methods, class variables) should match the business domain. For example, if a software processes loan applications, it might have classes like LoanApplication and Customer, and methods such as AcceptOffer and Withdraw. [Wikipedia 🌐](https://en.wikipedia.org/wiki/Domain-driven_design)

## What is Docker?
Docker is a set of platform as a service (PaaS) products that use OS-level virtualization to deliver software in packages called containers. The service has both free and premium tiers. The software that hosts the containers is called Docker Engine. [Wikipedia 🌐](https://en.wikipedia.org/wiki/Docker_(software))

## How to test?
```bash
docker build -t dotnetWithDdd ./RestWithDDD.Api

docker run -d -p 80:80 dotnetWithDdd
```