using Lauerp_Domain.DTOs;
using Lauerp_Domain.Interfaces;

namespace Lauerp_Domain.Services
{
    public class EventoService(IEventoRepository _eventoRepository) : IEventoService
    {
        public Task<List<EventoDTO>> ListaEventosAsync()
        {
            var eventos = _eventoRepository.ListaEventosAsync();

        }
    }
}
