using Lauerp_Application.Interfaces;
using Lauerp_Domain.Interfaces;

namespace Lauerp_Application.ApplicationService;

public class EventoApplicationService(IEventoService _eventoService) : IEventoAplication
{
   
    public Task ListaEventos()
    {
        throw new NotImplementedException();
    }
}
