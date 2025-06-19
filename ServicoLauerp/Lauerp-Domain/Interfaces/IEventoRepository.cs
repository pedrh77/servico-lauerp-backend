using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces;

public interface IEventoRepository
{
    Task<Evento> AddEventoAsync(Evento evento);
    Task<List<Evento>> ListaEventosAsync();
    Task<Evento> ListaEventosByIdAsync(int Id);
}
