using Lauerp_Aplication.Mapping;
using Lauerp_Application.ApplicationService;
using Lauerp_Application.Interfaces;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Services;
using Lauerp_Infra.Database;
using Lauerp_Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lauerp_IoC;

public static class BootStraper
{

    public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        RegisterApplication(services);
        RegisterMappingsProfile(services);
        RegisterRepositories(services);
        RegisterServices(services);


        DatabaseConfiguration(services, configuration);


        return services;
    }




    private static void DatabaseConfiguration(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<LauerpPostgreDbContext>(
            config => config.UseNpgsql(configuration.GetConnectionString("DatabaseConnection"), b => b.MigrationsAssembly("Lauerp-Infra"))
            );
    }

    public static void RegisterMappingsProfile(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(DomainToDTOProfile));
    }

    public static void RegisterServices(IServiceCollection services)
    {
        services.AddScoped<IEventoService, EventoService>();

    }

    public static void RegisterRepositories(IServiceCollection services)
    {
        services.AddScoped<IEventoRepository, EventoRepository>();
    }

    private static void RegisterApplication(IServiceCollection services)
    {
        services.AddScoped<IEventoAplication, EventoApplicationService>();
    }
}
