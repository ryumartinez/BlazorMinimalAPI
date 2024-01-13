using BlazorMinimalApis.Pages.Data.Domain;

namespace TestProject1;

public class DbTestSetup
{
    public static async Task SetupDatabase()
    {
        var dbContextFactory = new ApplicationDbContextFactory();
        using var dbContext = dbContextFactory.CreateDbContext(Array.Empty<string>());
        await dbContext.Database.EnsureDeletedAsync();
        await dbContext.Database.EnsureCreatedAsync();

        dbContext.ChangeTracker.AutoDetectChangesEnabled = false;
        await dbContext.Ingredients.AddAsync(new Ingredient() {Name = "hola", Price = 1233});
        await dbContext.SaveChangesAsync();
    }
}