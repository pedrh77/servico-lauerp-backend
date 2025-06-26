using Lauerp_Aplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class AulaController(IAulaApplication _aulaApplication) : ControllerBase
    {
        [HttpPost]
        public async IActionResult RegistraNovaAula()
        {
            
        }
    }
}
