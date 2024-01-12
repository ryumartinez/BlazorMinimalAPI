using Microsoft.EntityFrameworkCore;

namespace BlazorMinimalApis.Pages.Data;

public class RambosaDbContext : DbContext
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public RambosaDbContext(DbContextOptions<RambosaDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
    {
        _httpContextAccessor = httpContextAccessor;
    }
    public DbSet<Ingredient> Ingredients { get; set; } = null!;
}

public class Ingredient
{
    public int IngredientId { get; set; }
    public int Price { get; set; }
    public string Name { get; set; } = null!;
}