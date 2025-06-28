using Lauerp_Domain.DTOs.Login;
using Lauerp_Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class AuthController(IAuthService _authService) : ControllerBase
    {

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO login)
        {
            try
            {
                var result = await _authService.AutenticarAsync(login);
                return Ok(result);
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized("Credenciais inválidas.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("admin")]
        public IActionResult AdminArea()
        {
            return Ok("Você é admin!");
        }

        [Authorize(Roles = "Jogador")]
        [HttpGet("jogador")]
        public IActionResult JogadorArea()
        {
            return Ok("Você é jogador!");
        }

        [Authorize(Roles = "Professor")]
        [HttpGet("professor")]
        public IActionResult ProfessorArea()
        {
            return Ok("Você é professor!");
        }
    }
}
