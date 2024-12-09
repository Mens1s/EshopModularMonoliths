# EshopModularMonoliths
- Modular Monolithic Architecture with .NET

# Folder Structure

## Bootstrapper

- Contains main entry point of project.
- It is responsible for the exposing end modules for modules.
- It is easier to manage.

## Modules

- Contains of sub-folders for each module in our application.
- It obeys DDD.
- Every step of modules implemented in their sub-folders.

## Shared

- Contains comman and cross-cutting concerns they are used by the multiple modules.
- It helps to reduce code duplication and promotes re-usability.

# Module Architecture

## Vertical Slide Architecture
- Against to traditional layered/onion/clean architecture approaches.
- Aims to organize code around specific features or use cases, rather than tech. concerns.
- Feature is implemented across all layers of the software, from the user interface to the db.
- Divide application into distinc features or funcs.

## Clean Architecture
- Software architecture design that aims to seperate concerns and create systems that are indepented of frameworks, UI, and databases.
- Leads to systems that are more maintainable, flexible, and adaptable to changes.

### Layers
- Entites Layer - Domain Layer
- Contains enterprise-wide business rules.

- Use Cases Layer - Application Layer
- Contains application-specific business rules.

- Interface Adapters Layer - Infrastructure Layer
- Converts data from the format most conveinent for the use cases and entities.

- Frameworks and Drivers Layer
- REST controllers, db repos.