using Lauerp_Domain.DTOs.Esportes;
using Lauerp_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class EsportesController(IEsporteService _esporteService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> RegistraNovoEsporte([FromBody] NovoEsporteDTO request)
        {
            await _esporteService.RegistraNovoEsporteAsync(request);
            return Created();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscaEsportById(int id)
        {
            return Ok(await _esporteService.BuscaEsporteById(id));
        }

    }
}
