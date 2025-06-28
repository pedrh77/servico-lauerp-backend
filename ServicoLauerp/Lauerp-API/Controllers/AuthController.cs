using Lauerp_Domain.DTOs.Login;
using Lauerp_Domain.Interfaces;
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
    }
