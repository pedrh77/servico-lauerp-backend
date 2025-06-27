using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;
using Lauerp_Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Lauerp_Infra.Repository
{
    public class MatriculaRepository(LauerpPostgreDbContext _context) : IMatriculaRepository
    {
        public async Task<Matricula> BuscaMatriculaEmAulaAsync(int jogadorId, int aulaId, int ano, int semestre)
        {
            return await _context.Matriculas.FirstOrDefaultAsync(x => x.JogadorId.Equals(jogadorId)
                                                                        && x.AulaId.Equals(aulaId)
                                                                        && x.Ano.Equals(ano)
                                                                        && x.Semestre.Equals(semestre));
        }

        public async Task<Matricula> MatricularJogadorAsync(Matricula request)
        {
            request.AdicionaDadosBase();
            await _context.AddAsync(request);
            await _context.SaveChangesAsync();
            return request;
        }
    }
}
