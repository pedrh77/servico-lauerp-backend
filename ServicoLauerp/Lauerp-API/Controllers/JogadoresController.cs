using Lauerp_Domain.DTOs.Jogador;
using Lauerp_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lauerp_API.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class JogadoresController(IJogadorService _jogadoresServices) : ControllerBase
{

    [HttpPost("{MatricularJogadorAulaDTO.JogadorId}/Matricula")]
    public async Task<IActionResult> MatriculaJogador(MatricularJogadorAulaDTO request)
    {
        await _jogadoresServices.MatricularJogadorAsync(request);
        return Created();
    }
}
