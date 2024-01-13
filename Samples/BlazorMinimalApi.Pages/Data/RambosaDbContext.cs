using BlazorMinimalApis.Pages.Data.Domain;
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

