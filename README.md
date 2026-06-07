# Genova.Authorization

## Description

Provides authorization module integration for the Genova platform.

> [!WARNING]
> This codebase is part of the Genova platform and should not be considered production-ready. It is published as source for review, experimentation, and reuse within Genova-related projects.

> [!IMPORTANT]
> A fresh public clone of this repository should not be expected to restore or build without additional Genova infrastructure. Many Genova dependencies are distributed through a private authenticated NuGet feed, and the public source does not include feed credentials or a complete public package graph.

## Installation

Add the NuGet package reference or build the project with:

```bash
dotnet build
```

## Usage

Register the module with your Genova website or engine configuration:

```csharp
new AuthorizationModule()
```

## Features

* Provides a Genova module for authorization
* Integrates with the platform module system
* Targets .NET 8

## Notes

* Part of the Genova multi-tenant ASP.NET Core platform
* This is a class library module, not a standalone application

## License

GNU General Public License v3.0. See the `LICENSE` file for details.
