using Lauerp_Domain.DTOs;

namespace Lauerp_Domain.Interfaces;

public interface IEventoService
{
    Task<List<EventoDTO>> ListaEventosAsync();

}
