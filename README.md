# 🛒 E-Commerce Web API

A clean and scalable **ASP.NET Core Web API** project implementing a complete **CRUD** system for product management using **Asynchronous Programming** and a layered architecture.

## 🚀 Features

* ✅ RESTful API Design
* ✅ Full CRUD Operations
* ✅ Asynchronous Programming (async/await)
* ✅ Layered Architecture
* ✅ Repository Pattern
* ✅ Entity Framework Core
* ✅ SQL Server Database
* ✅ Dependency Injection
* ✅ DTO Pattern
* ✅ Model Validation
* ✅ Database Migrations

---

## 🏗️ Project Architecture

```
E-Commerce Web API
│
├── E-Commerce.Api
├── E-Commerce.Application
├── E-Commerce.Domain
└── E-Commerce.Infrastructure
```

### Layers

### API

* REST API Endpoints
* Dependency Injection Configuration
* Request Handling

### Application

* Business Logic
* DTOs
* Services
* Repository Interfaces

### Domain

* Entities
* Base Entity
* Domain Models

### Infrastructure

* Entity Framework Core
* SQL Server
* Repositories
* DbContext
* Migrations

---

## 🛠 Technologies

* ASP.NET Core Web API
* C#
* Entity Framework Core
* SQL Server
* LINQ
* Asynchronous Programming
* Dependency Injection
* Git
* GitHub

---

## 📌 CRUD Operations

| Method | Endpoint           | Description       |
| ------ | ------------------ | ----------------- |
| GET    | /api/products      | Get all products  |
| GET    | /api/products/{id} | Get product by id |
| POST   | /api/products      | Create product    |
| PUT    | /api/products/{id} | Update product    |
| DELETE | /api/products/{id} | Delete product    |

---

## ⚡ Asynchronous Programming

All database operations are implemented using asynchronous methods to improve application performance and scalability.

Examples include:

* GetAllAsync()
* GetByIdAsync()
* AddAsync()
* UpdateAsync()
* DeleteAsync()
* SaveChangesAsync()

---

## 📂 Getting Started

Clone the repository

```bash
git clone https://github.com/BabakSamadi/E-Commerce_WebApi.git
```

Navigate to the project

```bash
cd E-Commerce_WebApi
```

Restore packages

```bash
dotnet restore
```

Apply migrations

```bash
dotnet ef database update
```

Run the application

```bash
dotnet run
```

---

## 🎯 Learning Objectives

This project was developed to practice:

* Building RESTful APIs
* Clean Layered Architecture
* Repository Pattern
* Entity Framework Core
* Asynchronous Programming
* SQL Server Integration
* Git & GitHub Workflow

---

## 👨‍💻 Author

**Babak Samadi**

GitHub:
https://github.com/BabakSamadi
