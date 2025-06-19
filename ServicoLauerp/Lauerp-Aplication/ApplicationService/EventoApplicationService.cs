using Lauerp_Application.Interfaces;
using Lauerp_Domain.DTOs.Eventos;
using Lauerp_Domain.Interfaces;
using Lauerp_Domain.Models;

namespace Lauerp_Application.ApplicationService;

public class EventoApplicationService(IEventoService _eventoService) : IEventoAplication
{

    public async Task<List<EventoDTO>> ListaEventosAsync() => await _eventoService.ListaEventosAsync();

    public async Task<EventoDTO> ListaEventosByIdAsync(int Id) => await _eventoService.ListaEventosByIdAsync(Id);

    public async Task<Evento> NovoEventoAsync(NovoEventoDTO request) => await _eventoService.NovoEventoAsync(request);
}
