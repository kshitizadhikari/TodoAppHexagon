using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TodoAppHexagon.Adapaters.SqlServer.Data;
using TodoAppHexagon.Core.Ports;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<TodoDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<ITodoRepository, SqlServerTodoRepository>();
        return services;
    }
}
