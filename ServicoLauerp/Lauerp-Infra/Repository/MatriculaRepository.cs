using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;
using Lauerp_Infra.Database;

namespace Lauerp_Infra.Repository
{
    public class MatriculaRepository(LauerpPostgreDbContext _context) : IMatriculaRepository
    {
        public async Task<Matricula> MatricularJogadorAsync(Matricula request)
        {
            request.AdicionaDadosBase();
            await _context.AddAsync(request);
            await _context.SaveChangesAsync();
            return request;
        }
    }
}
