using Lauerp_Aplication.Interfaces;
using Lauerp_Domain.DTOs.Presenca;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class PresencaController(IPresencaApplication _presencaApplication) : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> AdicionaRegistroPresencaAsync(ResgistraPresencaDTO request)
        {
            await _presencaApplication.RegistraPresencaAsync(request);

            return Created();
        }
    }
}
