# CRUD app using MongoDB

This repository contains a sample .NET 7 Web API that uses MongoDB for CRUD operations and integrates with [Keploy](https://keploy.io) to auto-generate and run test cases by recording real API traffic.

---

## 📦 Tech Stack

- [.NET 8 Web API](https://dotnet.microsoft.com/)
- [MongoDB](https://www.mongodb.com/)
- [Keploy](https://keploy.io) – API testing and mocking tool

---

## 🚀 Getting Started

### 1. Clone the Repository

``` bash
git clone https://github.com/Pranav5255/samples-mongodb.git
cd samples-mongodb
```

### 2. Configure MongoDB
Update `appsettings.json` with your MongoDB connection string: 

``` json
{
  "ConnectionString": "mongodb://localhost:27017",
  "DatabaseName": "UserDb",
  "UsersCollectionName": "Users"
}
```
### 3. Run the .NET App
``` bash
dotnet run
```

App runs by default at:
``` arduino
http://localhost:5067
```

You can test endpoints like:
``` http
GET    /users
POST   /users
GET    /users/{id}
```

## 🐾 Generate Test Cases with Keploy
### 1. Download Keploy
``` powershell
curl -O -L https://keploy.io/install.sh && source install.sh
```

### 2. Record API Calls
``` bash
keploy.exe record --proxy-port 8080 --app-port 5067 --path ./keploy-tests
```

Now send traffic to:
``` bash
http://localhost:8080/users
```
Use Postman, Swagger or cURL to generate traffic.

### 3. Replay Tests
After Recording:
``` bash
keploy.exe test --path ./keploy-tests
```
