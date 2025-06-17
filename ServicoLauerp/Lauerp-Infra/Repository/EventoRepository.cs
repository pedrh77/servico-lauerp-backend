using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;
using Lauerp_Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Lauerp_Infra.Repository
{
    public class EventoRepository(LauerpPostgreDbContext _dbcontext) : IEventoRepository
    {
        public async Task<List<Evento>> ListaEventosAsync()
        {
            return await _dbcontext.Eventos.ToListAsync();
        }
    }
}
