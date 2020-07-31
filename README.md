# Basic ASP.NET Core tutorial from [ms docs](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio)

## Steps:

1. Create Models classes
2. Add `Microsoft.EntityFrameworkCore.SqlServer` and `Microsoft.EntityFrameworkCore.InMemory` NuGet packages
3. Create database context
4. Register database context service with dependency injection
5. Create Scaffold controller

## How to test the API:

1. Install tool for sendging API requests, eg. [Postman](https://www.postman.com/)
2. If using Postman temporarily disable SSL certificate verification: File > Settings (General tab), disable SSL certificate verification
3. Run Web API application and check port number in the browser
4. Create new POST request and open Body tab
5. Select raw radio button, set data type to JSON and paste this:

```javascript
  {
    "name":"walk dog",
    "isComplete":true
  }
```

6. Fill in URL address field with `https://localhost:<port>/api/TodoItems` and click Send
7. Read data location from response Headers
8. Test GET methods using this endpoints:

- GET /api/TodoItems
- GET /api/TodoItems/{id}

### Note:

This app uses an in-memory database. If the app is stopped and started, the preceding GET request will not return any data. If no data is returned, POST data to the app.
