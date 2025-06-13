using Lauerp_Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Lauerp_Infra.Database;

public class LauerpPostgreDbContext : DbContext
{
    public LauerpPostgreDbContext(DbContextOptions<LauerpPostgreDbContext> options) : base(options)
    {
    }

    public virtual DbSet<Professor> Professores { get; set; }
    public virtual DbSet<Professor> Jogadores { get; set; }
    public virtual DbSet<Professor> Esportes { get; set; }
}
