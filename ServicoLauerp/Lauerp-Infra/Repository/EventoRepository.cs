using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;
using Lauerp_Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Lauerp_Infra.Repository
{
    public class EventoRepository(LauerpPostgreDbContext _dbcontext) : IEventoRepository
    {
        public async Task<List<Evento>> ListaEventosAsync() => await _dbcontext.Eventos.Where(e => !e.Deleted).ToListAsync();

        public async Task<Evento> ListaEventosByIdAsync(int Id) => await _dbcontext.Eventos.FirstOrDefaultAsync(x => x.Id == Id);

        public async Task<int> AddEventoAsync(Evento evento)
        {
            try
            {
                evento.AdicionaDadosBase(); 
                await _dbcontext.Eventos.AddAsync(evento);
                await _dbcontext.SaveChangesAsync();
                return evento.Id;
            }
            catch (Exception ex)
            {
                throw new($"[AddEventoAsync]: Problemas ao Salvar Evento.");
            }
        }


    }
}
