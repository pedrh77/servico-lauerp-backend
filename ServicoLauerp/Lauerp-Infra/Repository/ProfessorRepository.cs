using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;
using Lauerp_Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Lauerp_Infra.Repository
{
    public class ProfessorRepository(LauerpPostgreDbContext _dbcontext) : IProfessorRepository
    {
        public async Task<int> AddProfessorAsync(Professor professor)
        {
            professor.AdicionaDadosBase();
            await _dbcontext.AddAsync(professor);
            await _dbcontext.SaveChangesAsync();
            return professor.Id;
        }

        public async Task<Professor> BuscaProfessorById(int professorId)
        {
            return await _dbcontext.Professores.FirstOrDefaultAsync(x => x.Id.Equals(professorId));
        }
    }
}
