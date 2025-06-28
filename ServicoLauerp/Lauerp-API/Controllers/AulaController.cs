using Lauerp_Domain.DTOs.Aulas;
using Lauerp_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class AulaController(IAulaService _aulaApplication) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> RegistraNovaAula(NovaAulaRequestDTO request)
        {
            await _aulaApplication.RegistraAulaAsync(request);
            return Created();
        }

        [HttpPost("Matricula")]
        public async Task<IActionResult> MatriculaJogadorAula(MatricularJogadorRequestDTO request)
        {
            await _aulaApplication.MatricularJogadorAsync(request);
            return Created();
        }
    }
}
