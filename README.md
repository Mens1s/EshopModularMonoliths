# EshopModularMonoliths
Modular Monolithic Architecture with .NET

# Folder Structure

## Bootstrapper

Contains main entry point of project.
It is responsible for the exposing end modules for modules.
It is easier to manage.

## Modules

Contains of sub-folders for each module in our application.
It obeys DDD.
Every step of modules implemented in their sub-folders.

## Shared

Contains comman and cross-cutting concerns they are used by the multiple modules.
It helps to reduce code duplication and promotes re-usability.