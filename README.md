# 🚀 Intern API with JWT Authentication (ASP.NET Core Web API)

A simple ASP.NET Core Web API project implementing JWT Authentication with CRUD operations for users using Entity Framework Core and SQL Server.

---

## 📌 Features

- 🔐 JWT Authentication (Login API)
- 👤 User Management (CRUD)
  - Create User (via DB / extension)
  - View Users
  - Update User
  - Delete User
- 🛡️ Protected routes using `[Authorize]`
- 🗄️ Entity Framework Core (Code First)
- 🧾 SQL Server Database integration
- 📡 Tested using Swagger & Postman

---

## 🏗️ Tech Stack

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT Bearer Authentication
- Swagger (API Testing)
- Postman

---

## 📁 Project Structure

InternApiJwtAuthentication
│
├── Controllers
│   └── UsersController.cs
│
├── Services
│   ├── UserService.cs
│   └── JwtService.cs
│
├── Repositories
│   └── UserRepository.cs
│
├── Models
│   └── User.cs
│
├── DTOs
│   ├── LoginDto.cs
│   └── UserUpdateDto.cs
│
├── Data
│   └── ApplicationDbContext.cs
│
└── Program.cs

## Authentication Flow

# Login:
**Endpoint**: POST /api/users/login
```json
    {
    "email": "test@gmail.com",
    "password": "123456"
    }
```
**Response**
```json
{
  "message": "Login successful",
  "token": "JWT_TOKEN_HERE"
}
```
## Authorize requests

**Authorization**: Bearer YOUR_TOKEN

### API Endpoints
## Authentication
| Method | Endpoint         | Description           |
| ------ | ---------------- | --------------------- |
| POST   | /api/users/login | Login & get JWT token |

## User APIs(Protected)
| Method | Endpoint               | Description   |
| ------ | ---------------------- | ------------- |
| GET    | /api/users/view        | Get all users |
| PUT    | /api/users/update/{id} | Update user   |
| DELETE | /api/users/delete/{id} | Delete user   |

### Testing tools
*Swagger UI* → API testing
*Postman* → Manual request testing

### Security Notes

- Passwords are stored as plain text (for learning purpose only ⚠️)
- JWT authentication is implemented for secured endpoints
- Email field has UNIQUE constraint in database

# 📄 License

This project is created for **learning and educational purposes only**.

You are free to:
- Use the code for learning
- Modify it for practice projects
- Use it as a reference for interviews or internships

You are NOT allowed to:
- Use this project in production without proper security improvements
- Claim it as a fully production-ready system
- Use it for commercial deployment without enhancements

---

# ⚠️ Disclaimer

This project is developed as a **student/intern-level learning project** using:

- ASP.NET Core Web API
- Entity Framework Core
- JWT Authentication

Important notes:
- Passwords are stored in plain text (NOT secure for production)
- No advanced security mechanisms (like refresh tokens, encryption) are implemented
- Error handling and validation are basic
- Intended only for **learning, demonstration, and academic purposes**

The author is not responsible for any misuse of this project.

## ⚙️ Installation & Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/preethivenkateshandec007-coder/InternAPIJwtAuthentication.git

## Author
**Preethi venkateshan**- preethivenkateshandec007@gmail.com
   
