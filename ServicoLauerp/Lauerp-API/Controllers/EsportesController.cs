using AutoMapper;
using Lauerp_Domain.DTOs.Esportes;
using Lauerp_Domain.DTOs.Eventos;
using Lauerp_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class EsportesController(IEsporteService _esporteService,IMapper _mapper) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> RegistraNovoEsporte([FromBody] NovoEsporteRequestDTO request)
        {
            await _esporteService.RegistraNovoEsporteAsync(request);
            return Created();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscaEsportById(int id)
        {
            return Ok(_mapper.Map<EsporteResponseDTO>(await _esporteService.BuscaEsporteById(id)));
        }

    }
}
