/**
 * 📌 Connection String Setup in .NET (Entity Framework Core)
 *
 * 🧱 Step 1: Install Required NuGet Packages
 * ------------------------------------------
 * - Microsoft.EntityFrameworkCore.SqlServer
 * - Microsoft.EntityFrameworkCore.Tools
 *
 * 💡 You can install them using the NuGet Package Manager or with the CLI:
 *   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
 *   dotnet add package Microsoft.EntityFrameworkCore.Tools
 *
 * 🔧 Step 2: Scaffold the DbContext and Models from an existing SQL Server database
 * ---------------------------------------------------------------------------------
 * Use the following command in the Package Manager Console (PMC):
 *
 * Scaffold-DbContext "Server=DESKTOP-KNIIU5R\\SQLEXPRESS;Database=CursoMvcCore;
 * Trusted_Connection=True; Encrypt=False;" 
 * Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/DB
 *
 * 📁 This will generate your DbContext and entity models inside the folder: Models/DB
 *
 * 🛡️ Tip: Avoid hardcoding your connection string in code. Store it in `appsettings.json`
 *        and use the `Name=` syntax instead to improve security.
 */
