# ArticleManagement

A simple REST API for managing articles, users, and comments. Built with ASP.NET Core and Entity Framework Core as part of a learning project focused on clean architecture and authentication using JWT.

## Endpoints
### Articles
- GET /api/articles – list and filter articles
- POST /api/articles – create a new article
- GET /api/articles/{id} – get article details
- PUT /api/articles/{id} – update an article
- DELETE /api/articles/{id} – delete an article
- PATCH /api/articles/{id}/visibility – change article visibility

### Comments
- GET /api/articles/{id}/comments – list comments for an article
- POST /api/articles/{id}/comments – add a comment
- GET /api/comments/{id} – get comment details
- PUT /api/comments/{id} – edit comment
- DELETE /api/comments/{id} – remove comment
- GET /api/users/{id}/comments – get comments by user

### Users
- POST /api/users/register – register a new user
- GET /api/users/{id} – get user details
- PATCH /api/users/{id}/role – change user role
- DELETE /api/users/{id} – delete user (admin only)
- DELETE /api/users/me – delete own account

### Authentication
- POST /api/auth/login – user login (returns tokens)
- POST /api/auth/refresh – refresh access token
- POST /api/auth/logout – logout and invalidate token

## Technologies

- C# / .NET 8
- ASP.NET Core
- Entity Framework Core
- Microsoft SQL Server
- JWT
- Swagger

## Installation and Setup
1. Clone the repository:
  ```bash
  git clone https://github.com/BartlomiejPalus/ArticleManagement.git
  ```
2. Open the solution in Visual Studio or Rider.
3. Add a file `appsettings.Development.json` to `ArticleManagement.API`:
   ```JSON
   {
    "Logging": {
      "LogLevel": {
        "Default": "Information",
        "Microsoft.AspNetCore": "Warning"
      }
    },
    "ConnectionStrings": {
      "Database": "CONNECTION_STRING"
    },
    "JWT": {
      "Secret": "SECRET_VALUE",
      "Issuer": "article-managment.com",
      "Audience": "articleManagmentAPI",
      "ExpirationInMinutes": 1,
      "RefreshTokenExpirationInDays": 7
    }
   }
   ```
4. Run EF Core migrations:
   ```
   Update-Database
   ```
6. Start the API project.
7. The API will be available at:
    -  `https://localhost:7096`
    -   Swagger UI: `https://localhost:7096/swagger/index.html`.
