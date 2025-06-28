using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;
using Lauerp_Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Lauerp_Infra.Repository
{
    public class AulaRepository(LauerpPostgreDbContext _dbcontext) : IAulaRepository
    {
        public async Task<Aula> AddAulaAsync(Aula aula)
        {
            await _dbcontext.AddAsync(aula);
            await _dbcontext.SaveChangesAsync();
            return aula;
        }

        public async Task<Aula> BuscarAulaById(int aulaId)
        {
            return await _dbcontext.Aulas.FirstOrDefaultAsync(x => x.Id.Equals(aulaId));
        }
    }
}
