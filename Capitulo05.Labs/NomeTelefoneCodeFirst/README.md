
## NuGet Packages

* Microsoft.EntityFrameworkCore 6.0.11
* Microsoft.EntityFrameworkCore.SqlServer 6.0.11
* Microsoft.EntityFrameworkCore.Tools 6.0.11
* Microsoft.VisualStudio.Web.CodeGeneration.Desi 6.0.1

## 1) Criar novo projeto

      ASP.NET Core Web App (Model-View-Controller)

## 2) Inserir o seguinte trecho em Program.cs

      builder.Services.AddDbContext<AgendaContext>(opt =>
      {
          opt.UseSqlServer(builder.Configuration.GetConnectionString("AgendaConnection"));
      });

## 3) Criar a connection string no appsettings.json

      "ConnectionStrings": {
            "AgendaConnection": "Server=localhost;Database=AgendaDb;Trusted_Connection=True;"
      }

# Passos para usar o Code Fisrt com EF Core:

* Criar o Model (ver Agenda.cs)
* Criar o DbContext para esse Model (ver AgendaContext.cs)
* Criar controller com Scaffolding

      (botão direito na pasta Controllers > Add > Controller... > MVC Controller with views, using Entity Framework)

* Abrir Console do Gerenciador de Pacotes

      Add-Migration NomeDaMigration
   
      Update-Database
