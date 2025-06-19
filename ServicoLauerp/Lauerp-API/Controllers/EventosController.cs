using Lauerp_Application.Interfaces;
using Lauerp_Domain.DTOs.Eventos;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class EventosController(IEventoAplication _eventoApplication) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> ListaEventosAsync()
    {
        var eventos = await _eventoApplication.ListaEventosAsync();

        if (eventos == null || !eventos.Any())
            return NoContent();

        return Ok(eventos);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> ListaEventosByIdAsync(int Id)
    {
        var eventos = await _eventoApplication.ListaEventosByIdAsync(Id);

        if (eventos == null)
            return NoContent();

        return Ok(eventos);
    }



    [HttpPost]
    public async Task<IActionResult> AdicionaNovoEventoAsync([FromBody] NovoEventoDTO NovoEventoDTO)
    {
        return Created("", await _eventoApplication.NovoEventoAsync(NovoEventoDTO));
    }
}
