using Lauerp_Domain.DTOs.Eventos;
using Lauerp_Domain.Models;

namespace Lauerp_Application.Interfaces;

public interface IEventoApplication
{
    Task<List<EventoDTO>> ListaEventosAsync();
    Task<EventoDTO> ListaEventosByIdAsync(int Id);
    Task<int> NovoEventoAsync(NovoEventoDTO request);
}
