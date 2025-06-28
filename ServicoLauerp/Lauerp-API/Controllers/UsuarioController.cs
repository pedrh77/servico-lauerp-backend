using Lauerp_Domain.DTOs.Usuario;
using Lauerp_Domain.Enum;
using Lauerp_Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Lauerp_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class UsuarioController(IUsuarioService _usuarioService) : ControllerBase
    {
        [Authorize(Roles ="Jogador")]
        [HttpPost("Novo")]
        public async Task<IActionResult> RegistraNovoUsuario(NovoUsuarioRequestDTO request)
        {
            await _usuarioService.RegistraNovoUsuario(request);
            return Created();
        }

    }
}
