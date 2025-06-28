using Lauerp_Domain.DTOs.Presenca;
using Lauerp_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class PresencaController(IPresencaService _presencaService) : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> AdicionaRegistroPresencaAsync(ResgistraPresencaRequestDTO request)
        {
            await _presencaService.RegistraPresencaAsync(request);

            return Created();
        }
    }
}
