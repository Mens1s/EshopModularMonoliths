
# InterviewHelper.md

## program.cs

### Dependency Injection
```csharp
builder.Services.Configure<JwtSection>(builder.Configuration.GetSection("JwtSection"));
```
This configuration mechanism, provided by Microsoft.Extensions.Configuration and Microsoft.Extensions.DependencyInjection libraries, integrates your application's configuration data into the Dependency Injection (DI) container, allowing easy access to configuration details.

With reflection, we can also access this configuration dynamically in runtime.

## appsettings.json

```json
"JwtSection": {
  "Key": "eyJSb2xlIjoiQWRtaW4iLCJJc3N1ZXIiOiJJc3N1Z",
  "Issuer": "https://localhost:7267",
  "Audience": "https://localhost:7267"
}
```

## JwtSection Class

```csharp
public class JwtSection
{
    public string? Key { get; set; }
    public string? Issuer { get; set; }
    public string? Audience { get; set; }
}
```

---

## Migration Commands

```bash
Add-Migration -o Data/Migrations
Update-Database
```

---

## Response

### Use `record`
A C# `record` is used to define immutable (unchangeable) data-carrying classes. Commonly employed for data modeling and DTOs (Data Transfer Objects), it:
- Provides value-based equality (two records are considered equal if their content is identical).
- Automatically implements `get` and `set` methods for properties.

---

## .NET 8 Backend

### Modular Monolith Architecture - Modulith

A balance between microservices and traditional monolithic applications, addressing issues like latency, data consistency, and fault tolerance in microservices while retaining the scalability and maintainability of monoliths.

### REDIS
Distributed caching solution.

### RabbitMQ
Event-driven synchronous communication.

### KeyCloak
API security management.

---

## Traditional Monolithic Architecture

### Characteristics
- All components and functionalities are packaged into a single cohesive unit.
  - UI, Business Logic, Data Access layers.
- Suitable for applications requiring strong consistency.
- Single codebase, single deployment unit, tight coupling, shared database.

### Downsides
- Difficult to scale.
- Complex codebase grows over time.
- Tight coupling makes changes risky.
- Hard to make new changes and slow development speed.
- Single point of failure.
- Rollbacks are challenging.
- Frequent downtime.
- Framework or language updates impact the entire application.
- Technical debt accumulates.
- Bug fixes and enhancements are slow.
- Team coordination issues.

---

## Concept of Big Ball of Mud

A messy, poorly structured software system. Quick fixes, rushing to deliver, and ignoring best practices lead to this.

---

## Microservices

Microservices are small, independent, and loosely coupled services that work together, communicating via well-defined APIs. Characteristics:
- Deployed independently.
- Technology-agnostic.
- Owns its database.

### Microservices Architecture

A single application developed as a suite of small services, each running in its process and communicating using lightweight mechanisms like HTTP or gRPC.

#### HTTP vs gRPC
- gRPC uses Protocol Buffers, language-agnostic, and serialized binary data (vs plain text in HTTP 1.1).
- Supports multiplexing and bidirectional full-duplex communication.
- Ideal for large data exchanges due to streaming features.

### Downsides
- Distributed systems challenges.
- Network latency and failures.
- Data consistency and duplication issues.
- Deployment and management complexity.
- Monitoring and logging challenges.
- Requires DevOps expertise.
- Service discovery tools like Consul, Eureka, or Kubernetes needed.
- Fault tolerance complexities.
- Debugging distributed systems requires tools like Jaeger and Zipkin.

---

## The Distributed Monolith (Antipattern)

A distributed monolith retains the drawbacks of monolithic architecture despite being structured as microservices.

### Common Issues
- Inadequate service boundaries.
- Lack of domain-driven design.
- Database coupling.
- Legacy code and practices.

---

## Modular Monolithic Architecture

A single cohesive application internally divided into well-defined, loosely coupled modules. Modules represent the bounded contexts of the application domain.

### Characteristics
- Modularity and bounded context.
- Simplified deployment and operations.
- Inter-module communication.
- Unified data management.

### Benefits Over Microservices
- Combines simplicity of monoliths with microservices' flexibility.
- Eliminates network communication complexities.
- Coordinated database schema ensures transactional integrity.
- Simplified scalability.
- Allows targeted scaling and optimization of specific modules.


### Internal Architecture 
- For less compelixt chooes N-Layer Arch., for more complex project choose Clean Arch.


### DI : Dependency Injection
- DI allows an object to receive its dependencies from an external source rather than creating itself.
- Promotes loose coupling and enhances testability and maintainability.
- DI container is configured in the Program.cs file.
- Kısacası bir class başka bir classı sıfırdan yaratması gereken durumlarda varolan yaratılmış class'a referans verme işlemidir.
- add transient service 
- builder.Services.AddTransient<ICustomerService, CustomerService>();
- it creates a new instance of the service for each request

- add scoped service
- builder.Services.AddScoped<ICustomerService, CustomerService>();
- it creates a new instance of the service for each scope

- add singleton service
- builder.Services.AddSingleton<ICustomerService, CustomerService>();
- it creates a single instance of the service for the lifetime of the application

