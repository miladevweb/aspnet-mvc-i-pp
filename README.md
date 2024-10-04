# Pull Docker Image

```bash
docker pull mcr.microsoft.com/mssql/server
```

# Create Docker Container

```bash
To Create
export SA_PASSWORD="My@Password"

To Get
echo $SA_PASSWORD
```

```bash
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=$SA_PASSWORD" -v sqlvolume:/var/opt/mssql -p 1433:1433 -d --rm --name mssql mcr.microsoft.com/mssql/server
```

<br>

# Make Scaffold

Through scaffold, we'll be able to visualize our data tables into the output-dir folder.

```bash
dotnet ef dbcontext scaffold "Server=localhost; Database=Pub; User ID=sa; Password=My@Password; TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models --force
```

<br>

# Add DbContext in Program.cs

```cs
// Add DbContext
builder.Services.AddDbContext<PubContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PubContext")));
```

-  Then Delete ConnectionString in DbContext

<br>

## Create a Controller and View

-  Inside of controller folder, we must create our controllers with this name **_SomethingController.cs_**

-  Each method within a controller class are paths. And a controller class must have a Index method **main path**.

<br>

Then, we should create a file with the controller methods name: **_Index.cshtml_** or **_Something.cshtml_**.

```html
<li class="nav-item">
   <a
      class="nav-link text-dark"
      asp-area=""
      asp-controller="Brand"
      asp-action="SecondaryRoute"
      >Secondary Route</a
   >
</li>
```

-  asp-controller: Controller name.

-  asp-action: Controller method.
