using BlazorMinimalApis.Pages.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TestProject1;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<RambosaDbContext>
{
    public RambosaDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<RambosaDbContext>()
            .UseSqlServer("Server=(local);Database=Rambosa;Integrated Security=True;MultipleActiveResultSets=False;TrustServerCertificate=True");

        return new RambosaDbContext(optionsBuilder.Options, null!);
    }
}