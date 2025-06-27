using Lauerp_Domain.DTOs.Eventos;
using Lauerp_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class EventosController(IEventoService _eventoServices) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> ListaEventosAsync()
    {
        var eventos = await _eventoServices.ListaEventosAsync();

        if (eventos == null || !eventos.Any())
            return NoContent();

        return Ok(eventos);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> ListaEventosByIdAsync(int Id)
    {
        var eventos = await _eventoServices.ListaEventosByIdAsync(Id);

        if (eventos == null)
            return NoContent();

        return Ok(eventos);
    }



    [HttpPost]
    public async Task<IActionResult> AdicionaNovoEventoAsync([FromBody] NovoEventoDTO NovoEventoDTO)
    {
        try
        {
            await _eventoServices.NovoEventoAsync(NovoEventoDTO);
            return Created();
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro ao Adicionar um novo Evento. Erro:{ex}");
        }

    }
}
