# Blazor Server Food Order App

A modern full-stack web application built with Blazor Server .NET 8, demonstrating clean architecture and modern development practices.

## 💫 Features

* **Modern Tech Stack**: Built with .NET 8 and Blazor Server
* **Data Management**: SQL Server database with Entity Framework Core
* **Containerization**: Complete Docker setup for development
* **CI/CD**: Automated testing and deployment pipeline with GitHub Actions
* **Clean Architecture**: Following best practices and SOLID principles

## 🛠️ Technology Stack

* **Frontend**: Blazor Server, Bootstrap 5
* **Backend**: .NET 8
* **ORM**: Entity Framework Core
* **Database**: SQL Server
* **Containerization**: Docker
* **CI/CD**: GitHub Actions

## ⚡ Getting Started

### Prerequisites

* .NET 8 SDK
* Docker Desktop
* Git

### Local Development Setup

1. Clone the repository:
```bash
git clone https://github.com/CarlBeullens/FoodOrderApp.git
cd FoodOrderApp
```

2. Start the SQL Server container:
```bash
docker-compose up -d
```

3. Run the application:
```bash
dotnet run
```

4. Access the application at `https://localhost:5233`

## 🐋 Docker Configuration

The project uses Docker for the database. Here's the configuration:

```yaml
    container_name: FoodOrderApp.db
    platform: linux/amd64 #Added to work on Mac M1
    image: mcr.microsoft.com/mssql/server:2022-latest
    environment:
      - ACCEPT_EULA=Y
      - MSSQL_SA_PASSWORD=Strong@Password123
      - MSSQL_PID=Express
    ports:
      - "1433:1433"
    volumes:
      - sqlserver_data:/var/opt/mssql
```

## 🔄 CI/CD Pipeline

This project implements a comprehensive GitHub Actions workflow that:

* Builds the application
* Runs unit tests
* Validates Docker configuration
* Ensures code quality

You can view the workflow in `.github/workflows/ci.yml`

## 💻 Development Features

* **Entity Framework Migrations**: Database schema is version controlled
* **Docker Support**: Containerized database for consistent development
* **Testing**: Unit tests and integration tests included
* **CI/CD**: Automated build and test pipeline

## 🔜 Future Enhancements

* Add user authentication and authorization
* Implement real-time notifications
* Add comprehensive unit test coverage
* Deploy to Azure

## 👤 Contact

Carl Beullens - [My LinkedIn](https://www.linkedin.com/in/carl-beullens)
