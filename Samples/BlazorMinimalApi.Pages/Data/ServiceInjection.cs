using Microsoft.EntityFrameworkCore;

namespace BlazorMinimalApis.Pages.Data;

public class ServiceInjection
{
    public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RambosaDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("SqlAzure");
            options.UseSqlServer(connectionString, opt => opt.EnableRetryOnFailure());
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });
    }
}