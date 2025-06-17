using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces
{
    public interface IEventoRepository
    {
        Task<List<Evento>> ListaEventosAsync();
    }
}
