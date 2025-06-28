using Lauerp_Aplication.Mapping;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Services;
using Lauerp_Infra.Database;
using Lauerp_Infra.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Lauerp_IoC;

public static class BootStraper
{

    public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        RegisterMappingsProfile(services);
        RegisterRepositories(services);
        RegisterServices(services);

        TokenInjection(services, configuration);

        DatabaseConfiguration(services, configuration);


        return services;
    }


    private static void TokenInjection(IServiceCollection services, IConfiguration configuration)
    {



        services.AddAuthentication(x =>
        {
            x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(configuration["Jwt:Key"]))
            };

            options.Events = new JwtBearerEvents
            {
                OnAuthenticationFailed = context =>
                {
                    Console.WriteLine("Token inválido: " + context.Exception.Message);
                    return Task.CompletedTask;
                },
                OnTokenValidated = context =>
                {
                    Console.WriteLine("Token válido para: " + context.Principal.Identity.Name);
                    return Task.CompletedTask;
                }
            };
        });
        services.AddAuthorization(options =>
        {
            options.AddPolicy("Admin", policy =>
                policy.RequireRole("Admin"));

            options.AddPolicy("Jogador", policy =>
                policy.RequireRole("Jogador"));

            options.AddPolicy("Professor", policy =>
                policy.RequireRole("Professor"));
        });

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
        services.AddScoped<IAulaService, AulaService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IEsporteService, EsporteService>();
        services.AddScoped<IEventoService, EventoService>();
        services.AddScoped<IMd5HashService, Md5HashService>();
        services.AddScoped<IPresencaService, PresencaService>();
        services.AddScoped<IUsuarioService, UsuarioService>();



    }

    public static void RegisterRepositories(IServiceCollection services)
    {

        services.AddScoped<IAulaRepository, AulaRepository>();
        services.AddScoped<IEventoRepository, EventoRepository>();
        services.AddScoped<IEsporteRepository, EsporteRepository>();
        services.AddScoped<IMatriculaRepository, MatriculaRepository>();
        services.AddScoped<IPresencaRepository, PresencaRepository>();
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
    }
}
