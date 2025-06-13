using Lauerp_Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class EventoController(IEventoAplication _eventoApplication) : ControllerBase
    {
        [HttpGet]
        public async Task ListaEventosAsync() => await _eventoApplication.ListaEventos();
    }
}
