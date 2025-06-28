using Lauerp_Domain.DTOs.Eventos;
using Lauerp_Domain.Models;

namespace Lauerp_Domain.Interfaces;

public interface IEventoService
{
    Task<List<EventoResponseDTO>> ListaEventosAsync();

    Task<EventoResponseDTO> ListaEventosByIdAsync(int Id);
    Task<int> NovoEventoAsync(NovoEventoRequestDTO request);
}
