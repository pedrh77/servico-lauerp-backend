using Lauerp_Aplication.Mapping;
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
        services.AddScoped<IProfessorService, ProfessorService>();
        services.AddScoped<IPresencaService, PresencaService>();
        services.AddScoped<IJogadorService, JogadorService>();
        services.AddScoped<IAulaService, AulaService>();
        services.AddScoped<IEsporteService, EsporteService>();

    }

    public static void RegisterRepositories(IServiceCollection services)
    {

        services.AddScoped<IEventoRepository, EventoRepository>();
        services.AddScoped<IProfessorRepository, ProfessorRepository>();
        services.AddScoped<IPresencaRepository, PresencaRepository>();
        services.AddScoped<IJogadorRepository, JogadorRepository>();
        services.AddScoped<IAulaRepository, AulaRepository>();
        services.AddScoped<IMatriculaRepository, MatriculaRepository>();

    }
}
