Simple Web API with .NET Core 7
PS: This project is under development!

With using Swagger, MVC and repository design pattern, a simple web api is being created.

NOTE: In order to use this project, please do followings:

1- Create a new ASP.NET Core Web API Project that named "webAPI" with selected "Enable OpenAPI support" and not selected "Configure for HTTPS" (with version .NET 7).  
2- Get the .NET Core CLI tools (See: https://learn.microsoft.com/en-us/ef/core/get-started/overview/install).  
3- Install Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Design.  
4- Copy and paste files under this repository to created project directory.  
5- Provide the SQL server name to the Context.serverName property in the Program.cs before migration step.  
6- Add migration with Entity Framework CLI from PM console.  
7- Update the database from PM Console.    
8- Build and run the project.  

Thank you! 
