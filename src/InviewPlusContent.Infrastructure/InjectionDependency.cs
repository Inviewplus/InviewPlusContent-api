using InviewPlusContent.Domain.Repositories;
using InviewPlusContent.Infrastructure.Database;
using InviewPlusContent.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace InviewPlusContent.Infrastructure;

public static class InjectionDependency
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ContentDbContext>(options =>
            options.UseNpgsql(Environment.GetEnvironmentVariable("DefaultConnection")));
        
        services.AddScoped<IContentRepository, ContentRepository>();

    }
}