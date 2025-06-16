using Lauerp_Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Lauerp_Infra.Database;

public class LauerpPostgreDbContext : DbContext
{
    public LauerpPostgreDbContext(DbContextOptions<LauerpPostgreDbContext> options) : base(options)
    {
    }

    public virtual DbSet<Professor> Professores { get; set; }
    public virtual DbSet<Jogador> Jogadores { get; set; }
    public virtual DbSet<Esporte> Esportes { get; set; }
}
