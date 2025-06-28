using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;
using Lauerp_Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Lauerp_Infra.Repository
{
    public class EsporteRepository(LauerpPostgreDbContext _context) : IEsporteRepository
    {
        public async Task<Esporte> AddEsporteAsync(Esporte esporte)
        {
            esporte.AdicionaDadosBase();
            await _context.AddAsync(esporte);
            await _context.SaveChangesAsync();
            return esporte;
        }

        public async Task<Esporte> BuscaEsporteById(int esporteId)
        {
            return await _context.Esportes.FirstOrDefaultAsync(x => x.Id.Equals(esporteId) && x.Deleted.Equals(false));
        }
    }
}
