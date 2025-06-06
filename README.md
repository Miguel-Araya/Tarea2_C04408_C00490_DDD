# .NET DDD Project – Person CRUD

This project is built with **C# and .NET**, following the principles of **Domain-Driven Design (DDD)**. It serves as a clean and maintainable example of implementing a **CRUD (Create, Read, Update, Delete)** for a `Person` entity.

## Architecture Overview

The solution is structured according to the DDD (Domain-Driven Design) approach and includes the following layers:

- **Domain:** Contains the core business logic, entities, value objects, and domain interfaces.
- **Application:** Contains use cases (application services) that coordinate domain operations.
- **Infrastructure:** Provides implementations for persistence (e.g., Entity Framework), external services, and technical concerns.
- **Presentation (API):** Exposes the application use cases via a RESTful Web API.

## Functionality

This project implements a basic **CRUD** for the `Person` entity, including:

- **Create Person**
- **Get Person by ID**
- **Update Person**
- **Delete Person**

Each operation respects the boundaries and responsibilities defined by DDD.

## Technologies Used

- .NET 8
- C#
- Entity Framework Core
- Swagger 

- Clear separation of concerns
- Dependency injection
- Domain logic encapsulated in entities and value objects
- Use of DTOs for API communication

