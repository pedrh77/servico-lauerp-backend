using Lauerp_Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Lauerp_Infra.Database;

public class LauerpPostgreDbContext : DbContext
{
    public LauerpPostgreDbContext(DbContextOptions<LauerpPostgreDbContext> options) : base(options)
    {
        
    }

    public DbSet<Esporte> Esportes { get; set; }
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<Presenca> Presencas { get; set; }
    public DbSet<Aula> Aulas { get; set; }
    public DbSet<Matricula> Matriculas { get; set; }

    public DbSet<Usuario> Usuarios { get; set; }
}
