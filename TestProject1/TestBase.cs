using BlazorMinimalApis.Pages.Data;

namespace TestProject1;

public class TestBase
{
    public RambosaDbContext Context { get; set; } = null!;

    public void SetupDbContext()
    {
        var dbContextFactory = new ApplicationDbContextFactory();
        Context = dbContextFactory.CreateDbContext(Array.Empty<string>());
    }

    [TearDown]
    public void TearDown()
    {
        Context?.Dispose();
    }
}