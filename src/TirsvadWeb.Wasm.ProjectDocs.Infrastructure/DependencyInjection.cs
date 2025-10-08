using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TirsvadWeb.Wasm.ProjectDocs.Application;
using TirsvadWeb.Wasm.ProjectDocs.Infrastructure.Persistence;

namespace TirsvadWeb.Wasm.ProjectDocs.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddApplication();
        var serviceProvider = services.BuildServiceProvider();
        var configuration = serviceProvider.GetRequiredService<IConfiguration>();

#if DEBUG
        Console.WriteLine("Using SQL Server LocalDB");
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DevConnection")));
#else
        Console.WriteLine("Using SQL Server");
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
#endif

        return services;
    }
}
