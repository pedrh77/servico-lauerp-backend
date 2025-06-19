using Lauerp_Domain.DTOs.Eventos;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces;

public interface IEventoService
{
    Task<List<EventoDTO>> ListaEventosAsync();

    Task<EventoDTO> ListaEventosByIdAsync(int Id);
    Task<Evento> NovoEventoAsync(NovoEventoDTO request);
}
