Packages / Installs:

- dotnet tool install --global dotnet-ef --version 8.0.6

- dotnet ef migrations add InitialCreate -o Data/Migrations 
    -to create migrations

-dotnet ef database update 
    - as we build application, and add new entites we will update the schema of the DB each time
