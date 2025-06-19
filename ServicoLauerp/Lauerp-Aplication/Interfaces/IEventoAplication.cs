using Lauerp_Domain.DTOs.Eventos;
using Lauerp_Domain.Models;

namespace Lauerp_Application.Interfaces;

public interface IEventoAplication
{
    Task<List<EventoDTO>> ListaEventosAsync();
    Task<EventoDTO> ListaEventosByIdAsync(int Id);
    Task<Evento> NovoEventoAsync(NovoEventoDTO request);
}
